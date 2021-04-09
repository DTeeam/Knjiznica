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
    public partial class DodajKnjigo : Form
    {
        List<Sekcija> sekcije;
        Knjiga k = new Knjiga();
        database_add_books_class db = new database_add_books_class();
        public DodajKnjigo()
        {
            InitializeComponent();

            sekcije = db.getSections();
            updateUDK();
        }

        private void updateUDK()
        {
            sekcije = db.getSections();
            udk_combo.Items.Clear();
            foreach (Sekcija s in sekcije)
            {
                udk_combo.Items.Add(s.ime);
            }
        }

        private void add_book_button_Click(object sender, EventArgs e)
        {
            int exists = 0;

            k.naslov = title_textBox.Text;
            k.avtor = author_textBox.Text;
            k.udk = udk_combo.Text;
            string udkS = udk_combo.Text;
            k.leto = Convert.ToInt32(year_numUpDown.Value);
            k.zalozba = publisher_textBox.Text;
            k.pridobitev = shop_checkedList.SelectedIndex;
            k.izgubljena = lost_checkedList.SelectedIndex;
            k.zapiski = notes_RtextBox.Text;

            foreach (Sekcija item in sekcije)
            {
                if (item.ime == udkS)
                    exists = 1;
            }

            if (exists == 1)
            {
                db.addBook(k);
                clearAll();
                MessageBox.Show("Knjiga uspešno dodana.");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Kategorija " + udkS +
                    " še ne obstaja.Ali jo želite dodati sedaj ? ", "Napaka", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.addSection(k);
                    db.addBook(k);
                    updateUDK();
                    clearAll();
                    MessageBox.Show("Knjiga uspešno dodana.");
                }
                else if (dialogResult == DialogResult.No)
                    updateUDK();
            }
        }

        private void clearAll()
        {
            title_textBox.Clear();
            author_textBox.Clear();
            udk_combo.Text = null;
            year_numUpDown.Value = 1900;
            publisher_textBox.Clear();
            shop_checkedList.Items.Clear();
            lost_checkedList.Items.Clear();
            notes_RtextBox.Clear();
        }

        private void shop_checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < shop_checkedList.Items.Count; ++ix)
                    if (e.Index != ix) shop_checkedList.SetItemChecked(ix, false);
        }

        private void lost_checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < lost_checkedList.Items.Count; ++ix)
                    if (e.Index != ix) lost_checkedList.SetItemChecked(ix, false);
        }
    }
}
