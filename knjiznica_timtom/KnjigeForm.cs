using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace knjiznica_timtom
{
    public partial class KnjigeForm : Form
    {
        List<Knjiga> booklist;
        List<Clan> clanilist;
        List<Izposoja> izposoje;
        List<int> iz_id = new List<int>();
        List<Sekcija> sekcije = new List<Sekcija>();

        Knjiga k = new Knjiga();
        DBClass db = new DBClass();
        ClaniClass cb = new ClaniClass();
        IskanjeClass search = new IskanjeClass();

        int id = 0;
        int clan_id = 0;

        bool spremembe = false;

        public KnjigeForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            section_combo.SelectedIndex = 0;

            if (spremembe)
                fillListView();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (book_listView.SelectedItems.Count == 0)
                MessageBox.Show("Prosim izberite knjigo za urejanje.");
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
            spremembe = false;
            section_combo.Items.Clear();
            section_combo.Items.Add("--Izberite--");

            book_listView.Items.Clear();
            booklist = db.GetAllBooks();
            sekcije = db.returnsekcije();

            foreach (Knjiga a in booklist)
            {
                ListViewItem newList = new ListViewItem(a.inventarna_stevilka.ToString());
                newList.UseItemStyleForSubItems = false;

                newList.SubItems.Add(a.naslov);
                newList.SubItems.Add(a.avtor);
                newList.SubItems.Add(a.zalozba);
                newList.SubItems.Add("");

                if (a.zasedena == 1)
                    newList.SubItems[4].BackColor = Color.Red;
                else
                    newList.SubItems[4].BackColor = Color.Green;

                book_listView.Items.Add(newList);
            }

            foreach(Sekcija a in sekcije)
            {
                section_combo.Items.Add(a.ime);
            }
        }

        private void update_list()
        {
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

        private void clani_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl2.Enabled = true;

            clan_id = clanilist[clani_combo.SelectedIndex].id;


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
            try
            {
                int index = izposoje_listview.SelectedItems[0].Index;
                int stanje = izposoje[index].stanje;

                if (stanje == 1)
                {
                    return_butt.Enabled = true;
                }
            }
            catch (Exception)
            {
                return_butt.Enabled = false;
                izposoje_listview.SelectedItems.Clear();
            }
        }

        private void return_butt_Click(object sender, EventArgs e)
        {
            return_butt.Enabled = false;
            try
            {
                int index = izposoje_listview.SelectedItems[0].Index;

                int id_izposoje = izposoje[index].id;

                int stanje = cb.vrni(id_izposoje);

                if (stanje == 0)
                {
                    MessageBox.Show("Vrnjeno");
                }
                else
                {
                    MessageBox.Show("Napaka");
                }
            }
            catch (Exception)
            {
                izposoje_listview.SelectedItems.Clear();
            }
            update_list();
            spremembe = true;
        }

        private void izposoja_user_tab_Enter(object sender, EventArgs e)
        {
            update_list();

            section_clani_combo.Items.Clear();
            section_clani_combo.Items.Add("--Izberite--");

            sekcije = db.returnsekcije();

            foreach (Sekcija a in sekcije)
            {
                section_clani_combo.Items.Add(a.ime);
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

        private void book_list_iz_SelectedIndexChanged(object sender, EventArgs e)
        {
            dodaj_na_seznam.Enabled = true;
        }

        private void dodaj_na_seznam_Click(object sender, EventArgs e)
        {
            Knjiga a = booklist[book_list_iz.SelectedItems[0].Index];

            if(iz_id.Contains(a.inventarna_stevilka))
            {
                MessageBox.Show("Knjiga je že dodana");
            }
            else
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

                booklist_zaiz.Items.Add(newList);

                iz_id.Add(a.inventarna_stevilka);
            }

            dodaj_na_seznam.Enabled = false;
        }

        private void booklist_zaiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            odstranu_iz_seznama.Enabled = true;
        }

        private void odstranu_iz_seznama_Click(object sender, EventArgs e)
        {
            Knjiga a = booklist[booklist_zaiz.SelectedItems[0].Index];

            iz_id.Remove(a.inventarna_stevilka);

            booklist_zaiz.SelectedItems[0].Remove();

            odstranu_iz_seznama.Enabled = false;
        }

        private void izpsosodi_Click(object sender, EventArgs e)
        {
            cb.izposodi_knjige(iz_id, clan_id);

            iz_id.Clear();

            update_list();

            booklist_zaiz.Items.Clear();
            spremembe = true;

            dodaj_na_seznam.Enabled = false;
            odstranu_iz_seznama.Enabled = false;

            MessageBox.Show("Knjige so izposojene");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void KnjigeForm_Load(object sender, EventArgs e)
        {
            fillListView();
        }

        private void searching(string searchstring, int id)
        {
            book_listView.Items.Clear();
            spremembe = false;

            if (id == 0)
            {
                booklist = search.GetAllBooksSearch(searchstring);
            }

            else
            {
                booklist = search.GetAllBooksSearchWithSection(searchstring, id);
            }

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

        private void search_button_Click(object sender, EventArgs e)
        {
            string searchstring = search_text.Text;
            int id;

            if (section_combo.SelectedIndex == 0 || section_combo.SelectedIndex == -1)
            {
                id = 0;
            }
            else
            {
                id = sekcije[section_combo.SelectedIndex].id;
            }

            section_combo.SelectedIndex = 0;
            search_text.Text = "";

            searching(searchstring, id);
        }

        private void search_clani_button_Click(object sender, EventArgs e)
        {
            string searchstring = search_clani_text.Text;
            int id;

            if (section_clani_combo.SelectedIndex == 0 || section_clani_combo.SelectedIndex == -1)
            {
                booklist = search.GetAllAvaliableBooksSearch(searchstring);
            }
            else
            {
                id = sekcije[section_clani_combo.SelectedIndex].id;
                booklist = search.GetAllAvaliableBooksSearchWithSection(searchstring, id);
            }

            book_list_iz.Items.Clear();

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

        private void insert_button_Click(object sender, EventArgs e)
        {
            var dodaj = new DodajKnjigo();
            dodaj.Show();

            spremembe = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var posodobi = new PosodobiKnjigo(id, this);
                posodobi.Show();
            }
            else
                MessageBox.Show("Prosim, izberite knjigo za urejanje.");
        }
        public void reloadKnjige()
        {
            fillListView();
        }

        public void ListToExcel(List<Knjiga> list)
        {
            NsExcel.ApplicationClass excapp = new Microsoft.Office.Interop.Excel.ApplicationClass();        
            excapp.Visible = true;

            var workbook = excapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);

            var sheet = (NsExcel.Worksheet)workbook.Sheets[1];

            string cellName;
            int counter = 1;

            cellName = "A" + counter.ToString();
            var range = sheet.get_Range(cellName, cellName);
            range.Value2 = "Inventarna številka";

            cellName = "B" + counter.ToString();
            range = sheet.get_Range(cellName, cellName);
            range.Value2 = "Naslov";

            cellName = "C" + counter.ToString();
            range = sheet.get_Range(cellName, cellName);
            range.Value2 = "Avtor";

            cellName = "D" + counter.ToString();
            range = sheet.get_Range(cellName, cellName);
            range.Value2 = "Založba";

            counter++;

            foreach (Knjiga item in list)
            {
                cellName = "A" + counter.ToString();
                range = sheet.get_Range(cellName, cellName);
                range.Value2 = item.inventarna_stevilka;

                cellName = "B" + counter.ToString();
                range = sheet.get_Range(cellName, cellName);
                range.Value2 = item.naslov;

                cellName = "C" + counter.ToString();
                range = sheet.get_Range(cellName, cellName);
                range.Value2 = item.avtor;

                cellName = "D" + counter.ToString();
                range = sheet.get_Range(cellName, cellName);
                range.Value2 = item.zalozba;
                ++counter;
            }
        }

        private void excel_button_Click(object sender, EventArgs e)
        {
            ListToExcel(booklist);
        }
    }

}
