using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class database_update_books_class
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Knjiga> getBooks(int id)
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, s.name FROM books b INNER JOIN sections s ON s.id = b.section_id WHERE b.id = " + id + ";";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Knjiga k = new Knjiga();

                    k.inventarna_stevilka = reader.GetInt32(0);
                    k.naslov = reader.GetString(1);
                    k.pridobitev = reader.GetInt32(2);
                    k.zapiski = reader.GetString(3);
                    k.leto = reader.GetInt32(5);
                    k.avtor = reader.GetString(6);
                    k.zalozba = reader.GetString(7);
                    k.izgubljena = reader.GetInt32(8);
                    k.udk = reader.GetString(9);

                    list.Add(k);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
        public void updateBook(Knjiga k, int id)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText =  "UPDATE books SET title = '" + k.naslov + "', shop = " + k.pridobitev + ", notes = '" + k.zapiski + "', section_id = (SELECT id FROM sections WHERE name = '" + k.udk + "'), year = " + k.leto + ", author = '" + k.avtor + "', publisher = '" + k.zalozba + "', lost = " + k.izgubljena + " WHERE id = " + id + ";";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }
    }
}
