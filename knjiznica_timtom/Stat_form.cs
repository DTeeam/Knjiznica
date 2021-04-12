using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knjiznica_timtom
{
    public partial class Stat_form : Form
    {
        List<Izposoja> list;
        stats st = new stats();

        int leto1, leto2;

        List<string> lista = new List<string>();
        public Stat_form(int a, int b)
        {
            InitializeComponent();
            leto1 = a; leto2 = b;
        }

        private void doinstuff()
        {
            SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT s.name, r.date FROM rents r LEFT JOIN books b ON b.id = r.book_id LEFT JOIN sections s ON s.id = b.section_id;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string date = reader.GetString(1);

                    string[] split = date.Split();
                    int leto = Convert.ToInt32(split[2]);

                    if (leto >= leto1 && leto <= leto2)
                        lista.Add(name);
                }

                com.Dispose();
            }

            conn.Close();
        }

        private void Stat_form_Load(object sender, EventArgs e)
        {
            list = st.GetRents();

            int i = 0;

            foreach(Izposoja a in list)
            {
                string date = a.datum_izposoje;
                string[] split = date.Split();
                int leto = Convert.ToInt32(split[2]);

                if (leto >= leto1 && leto <= leto2)
                    i++;
            }

            rent_chart.Series["Izposoje v tem času"].Points.AddXY(leto1 + " - " + leto2, i);

            doinstuff();

            var q = from x in lista
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                section_chart.Series["UDK"].Points.AddXY(x.Value, x.Count);
            }
        }
    }
}
