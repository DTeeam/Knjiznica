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
        DBClass db = new DBClass();

        public KnjigeForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            book_listView.Items.Clear();

            booklist = db.GetAllBooks();

            foreach (Knjiga a in booklist)
            {
                ListViewItem newList = new ListViewItem(a.inventarna_stevilka.ToString());

                newList.SubItems.Add(a.naslov);
                newList.SubItems.Add(a.avtor);

                book_listView.Items.Add(newList);
                //book_listView.Items.Add(a.inventarna_stevilka.ToString(), a.naslov);

            }
        }
    }
}
