using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class database_addEdit_books_class
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
