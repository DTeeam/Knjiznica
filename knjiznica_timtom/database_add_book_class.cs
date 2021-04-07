using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class database_add_book_class
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Knjiga> getSections()
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT name FROM sections;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Knjiga a = new Knjiga();

                    a.udk = reader.GetString(0);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
    }
}
