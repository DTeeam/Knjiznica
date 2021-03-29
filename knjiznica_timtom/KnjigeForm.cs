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
        List<Clan> clanilist;
        List<Izposoja> izposoje;

        Knjiga k = new Knjiga();
        DBClass db = new DBClass();
        ClaniClass cb = new ClaniClass();

        int id = 0;
        int clan_id = 0;

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

        private void clani_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl2.Enabled = true;

            clan_id = clanilist[clani_combo.SelectedIndex].id;

            izposoje = cb.GetAllIzposojaForUser(clan_id);

            izposoje_listview.Items.Clear();
            foreach (Izposoja a in izposoje)
            {
                ListViewItem newList = new ListViewItem(a.id_knjige.ToString());
                newList.UseItemStyleForSubItems = false;

                newList.SubItems.Add("");
                newList.SubItems.Add(a.datum_izposoje);

                if (a.stanje == 1)
                    newList.SubItems[1].BackColor = Color.Red;
                else
                    newList.SubItems[1].BackColor = Color.Green;

                izposoje_listview.Items.Add(newList);

            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            clanilist = cb.GetAllClani();

            foreach(Clan a in clanilist)
            {
                clani_combo.Items.Add(a.ime + " " + a.priimek);
            }
        }

        private void izposoje_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            return_butt.Enabled = true;
        }

        private void return_butt_Click(object sender, EventArgs e)
        {
            return_butt.Enabled = false;
        }
    }
}
