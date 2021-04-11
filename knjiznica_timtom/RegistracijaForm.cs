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
    public partial class RegistracijaForm : Form
    {
        Admin admin = new Admin();
        database_registration_class db = new database_registration_class();
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            admin.upIme = user_text.Text;
            admin.pass = pass_text.Text;
            admin.repPass = rep_pass_text.Text;

            if (admin.pass != admin.repPass)
                MessageBox.Show("Gesli se ne ujemata.");

            else
            {
                db.registerUser(admin);
                MessageBox.Show("Registracija uspešna.");
                this.Close();
            }
        }
    }
}
