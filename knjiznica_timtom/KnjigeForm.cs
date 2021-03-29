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

        private void update_list()
        {
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

        private void clani_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl2.Enabled = true;

            update_list();

            Clan aa = clanilist[clani_combo.SelectedIndex];

            ime_c_text.Text = aa.ime;
            priimek_c_text.Text = aa.priimek;
            tel_c_text.Text = aa.telefon;
            email_c_text.Text = aa.email;
            naslov_c_text.Text = aa.naslov;
            notes_c_text.Text = aa.zapiski;
        }

        public void update_clani()
        {
            clani_combo.Items.Clear();

            clanilist = cb.GetAllClani();

            foreach (Clan a in clanilist)
            {
                clani_combo.Items.Add(a.ime + " " + a.priimek);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            update_clani();
        }

        private void izposoje_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stanje = izposoje[izposoje_listview.SelectedItems[0].Index].stanje;

            if (stanje == 1)
            {
               return_butt.Enabled = true;
            }
        }

        private void return_butt_Click(object sender, EventArgs e)
        {
            return_butt.Enabled = false;

            int id_izposoje = izposoje[izposoje_listview.SelectedItems[0].Index].id;

            int stanje = cb.vrni(id_izposoje);

            if(stanje == 0)
            {
                MessageBox.Show("Vrnjeno");
            }
            else
            {
                MessageBox.Show("Napaka");
            }

            update_list();
        }

        private void izposoja_user_tab_Enter(object sender, EventArgs e)
        {
            book_list_iz.Items.Clear();
            booklist = cb.GetAllAvaliableBooks();

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

                book_list_iz.Items.Add(newList);

            }
        }

        private void spremeni_podatke_Click(object sender, EventArgs e)
        {
            int index = clani_combo.SelectedIndex;

            cb.posodobiClana(clan_id, ime_c_text.Text, priimek_c_text.Text, naslov_c_text.Text, tel_c_text.Text, email_c_text.Text, notes_c_text.Text);

            update_clani();

            clani_combo.SelectedIndex = index;
        }

        private void zbrisi_user_Click(object sender, EventArgs e)
        {
            cb.zbrisiclana(clan_id);

            clan_id = 0;

            update_clani();

            clani_combo.SelectedIndex = 0;
        }

        private void dodaj_clana_Click(object sender, EventArgs e)
        {
            cb.dodajClana(name_text.Text, sur_text.Text, add_text.Text, tel_text.Text, mail_text.Text, notes_text.Text);

            MessageBox.Show("Član dodan");

            name_text.Text = ""; sur_text.Text = ""; add_text.Text = ""; tel_text.Text = ""; mail_text.Text = ""; notes_text.Text = "";
        }
    }
}
