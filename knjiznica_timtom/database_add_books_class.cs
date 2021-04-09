using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class database_add_books_class
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Sekcija> getSections()
        {
            List<Sekcija> list = new List<Sekcija>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT * FROM sections;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Sekcija a = new Sekcija();

                    a.id = reader.GetInt32(0);
                    a.ime = reader.GetString(1);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
        public void addBook(Knjiga k)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO books(title, shop, notes, section_id, year, author, publisher, lost)" +
                    "VALUES('" + k.naslov + "', " + k.pridobitev + ", '" + k.zapiski + "'," +
                    "(SELECT id FROM sections WHERE name = '" + k.udk + "'), " + k.leto + ", '" + k.avtor + "', '" + k.zalozba + "', " + k.izgubljena + "); ";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }
        public void addSection(Knjiga k)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO sections(name) VALUES('" + k.udk + "'); ";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }
    }
}
