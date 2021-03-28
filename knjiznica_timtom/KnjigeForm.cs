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
    public partial class KnjigeForm : Form
    {
        List<Knjiga> booklist;
        Knjiga k = new Knjiga();
        DBClass db = new DBClass();
        int id = 0;
        public KnjigeForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            fillListView();
        }



        private void change_button_Click(object sender, EventArgs e)
        {
            book_listView.LabelEdit = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            db.deleteBook(k);
            fillListView();

        }

        private void book_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string item = string.Empty;

            for (int i = 0; i < book_listView.SelectedItems.Count; i++)
            {
                if (book_listView.SelectedItems[i].Selected)
                {
                    int i2 = book_listView.SelectedItems[i].Index;
                    item = book_listView.Items[i2].Text;
                    id = Convert.ToInt32(item);
                    k.inventarna_stevilka = id;
                }
            }
        }

        private void fillListView()
        {
            book_listView.Items.Clear();
            booklist = db.GetAllBooks();

            foreach (Knjiga a in booklist)
            {
                ListViewItem newList = new ListViewItem(a.inventarna_stevilka.ToString());
                newList.UseItemStyleForSubItems = false;

                newList.SubItems.Add(a.naslov);
                newList.SubItems.Add(a.avtor);
                newList.SubItems.Add("");

                if (a.zasedena == 1)
                    newList.SubItems[3].BackColor = Color.Red;
                else
                    newList.SubItems[3].BackColor = Color.Green;

                book_listView.Items.Add(newList);

            }
        }
    }
}
