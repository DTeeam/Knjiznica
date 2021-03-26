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
            book_listbox.Items.Clear();

            booklist = db.GetAllBooks();

            foreach (Knjiga a in booklist)
                book_listbox.Items.Add(a.inventarna_stevilka + " | " + a.naslov);
        }
    }
}
