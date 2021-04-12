using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knjiznica_timtom
{
    public partial class PosodobiKnjigo : Form
    {
        List<Sekcija> sekcije;
        Knjiga k = new Knjiga();
        KnjigeForm knjigaForm;
        database_update_books_class db = new database_update_books_class();
        database_add_books_class dbS = new database_add_books_class();
        List<Knjiga> knjigeList = new List<Knjiga>();
        int bookID = 0;
        public PosodobiKnjigo(int id, KnjigeForm knjigeForm)
        {
            InitializeComponent();
            bookID = id;
            sekcije = dbS.getSections();
            knjigeList = db.getBooks(bookID);
            updateUDK();
            fillFields();
            knjigaForm = knjigeForm;
        }

        private void update_book_button_Click(object sender, EventArgs e)
        {
            int exists = 0;

            k.naslov = title_textBox.Text;
            k.avtor = author_textBox.Text;
            k.udk = udk_combo.Text;
            string udkS = udk_combo.Text;
            k.leto = Convert.ToInt32(year_numUpDown.Value);
            k.pridobitev = shop_checkedList.TabIndex;
            k.zalozba = publisher_textBox.Text;
            k.zapiski = notes_RtextBox.Text;

            if (lost_checkedList.Checked == true)
                k.izgubljena = 1;
            else
                k.izgubljena = 0;

            if (nakupRadio.Checked == true)
                k.pridobitev = 0;
            else if (dariloRadio.Checked == true)
                k.pridobitev = 1;
            else
                k.pridobitev = 2;


            if (k.pridobitev != -1 && k.izgubljena != -1)
             {
                 foreach (Sekcija item in sekcije)
                 {
                     if (item.ime == udkS)
                         exists = 1;
                 }

                 if (exists == 1)
                 {
                     db.updateBook(k, bookID);
                     MessageBox.Show("Knjiga uspešno posodobljena.");
                 }

                 else
                 {
                     DialogResult dialogResult = MessageBox.Show("Kategorija " + udkS +
                         " še ne obstaja. Ali jo želite dodati sedaj? ", "Napaka", MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
                     {
                         dbS.addSection(k);
                         db.updateBook(k, bookID);

                         MessageBox.Show("Knjiga uspešno posodobljena.");

                         updateUDK();
                     }
                     else if (dialogResult == DialogResult.No)
                         updateUDK();
                 }
                 knjigaForm.reloadKnjige();
                this.Close();

             }
             else
                 MessageBox.Show("Prosim izpolnite polja Pridobitev in Izgubljena."); 
        }
        private void fillFields()
        {
            foreach(Knjiga item in knjigeList)
            {
                title_textBox.Text = item.naslov;
                author_textBox.Text = item.avtor;
                udk_combo.Text = item.udk;
                year_numUpDown.Value = item.leto;
                publisher_textBox.Text = item.zalozba;
                notes_RtextBox.Text = item.zapiski;

                if (item.izgubljena == 1)
                    lost_checkedList.Checked = true;
                else
                    lost_checkedList.Checked = false;

                if (item.pridobitev == 0)
                    nakupRadio.Checked = true;
                else if (k.pridobitev == 1)
                    dariloRadio.Checked = true;
                else
                    ostaloRadio.Checked = true;
            }
        }
        private void updateUDK()
        {
            udk_combo.Items.Clear();
            foreach (Sekcija item in sekcije)
                udk_combo.Items.Add(item.ime);
        }
    }
}
