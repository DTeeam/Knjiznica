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
    public partial class PrijavaForm : Form
    {
        DBClass db = new DBClass();
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            int id = db.GetAdminUserID(user_text.Text, pass_text.Text);

            if (id != 0)
            {
                this.Hide();
                var knjigeForm = new KnjigeForm();
                knjigeForm.FormClosed += (s, args) => this.Close();
                knjigeForm.Show();
            }

            else
                MessageBox.Show("Napačni podatki");
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            int id = db.GetAdminUserID(user_text.Text, pass_text.Text);

            if (id != 0)
            {
                var registracija = new RegistracijaForm();
                registracija.Show();
            }

            else
                MessageBox.Show("Uporabite validne podatke za registracijo novega uporabnika");
        }
    }
}
