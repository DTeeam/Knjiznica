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
        List<Knjiga> booklist;
        Knjiga k = new Knjiga();
        database_addEdit_books_class db = new database_addEdit_books_class();
        public DodajKnjigo()
        {
            InitializeComponent();

            booklist = db.getSections();
            foreach(Knjiga k in booklist)
            {
                udk_combo.Items.Add(k.udk);
            }
        }

        private void add_book_button_Click(object sender, EventArgs e)
        {
            k.naslov = title_textBox.Text;
            k.avtor = author_textBox.Text;
            k.udk = udk_combo.SelectedItem.ToString();
            k.leto = Convert.ToInt32(year_numUpDown.Value);
            k.zalozba = publisher_textBox.Text;
            k.pridobitev = shop_checkedList.SelectedIndex;
            k.izgubljena = lost_checkedList.SelectedIndex;
            k.zapiski = notes_RtextBox.Text;

            db.addBook(k);
            MessageBox.Show("Knjiga uspešno dodana.");
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
