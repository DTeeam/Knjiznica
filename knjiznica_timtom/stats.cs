using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class stats
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Izposoja> GetRents()
        {
            List<Izposoja> list = new List<Izposoja>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT user_id, book_id, state, date FROM rents ORDER BY id;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Izposoja a = new Izposoja();

                    a.id_clana = reader.GetInt32(0);
                    a.id_knjige = reader.GetInt32(1);
                    a.stanje = reader.GetInt32(2);
                    a.datum_izposoje = reader.GetString(3);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
    }
}
