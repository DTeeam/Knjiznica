using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace knjiznica_timtom
{
    public class DBClass
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public int GetAdminUserID(string user, string pass)
        {
            int id = 0; 

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT id FROM admin_users WHERE username = '" + user + "' AND password = '" + pass + "';";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                    id = reader.GetInt32(0);

                com.Dispose();
            }

            conn.Close();

            return id;
        }

        public List<Knjiga> GetAllBooks()
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, r1.state FROM books b LEFT OUTER JOIN (SELECT book_id, MAX(id) AS latest FROM rents GROUP BY book_id) AS rent ON rent.book_id = b.id LEFT OUTER JOIN rents r1 ON rent.book_id = r1.book_id AND r1.id = rent.latest GROUP BY b.id";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Knjiga a = new Knjiga();

                    a.inventarna_stevilka = reader.GetInt32(0);
                    a.naslov = reader.GetString(1);
                    a.avtor = reader.GetString(6);
                    a.izgubljena = reader.GetInt32(8);

                    if (reader.IsDBNull(9))
                        a.zasedena = 0;
                    else
                        a.zasedena = reader.GetInt32(9);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }

        public void deleteBook(Knjiga k)
        {
            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "DELETE FROM books WHERE id = " + k.inventarna_stevilka + ";";
                com.ExecuteNonQuery();
                com.Dispose();
            }

            conn.Close();
        }

        public List<Sekcija> returnsekcije()
        {
            List<Sekcija> sekcije = new List<Sekcija>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT * FROM sections;";
                SQLiteDataReader getReader = com.ExecuteReader();

                while(getReader.Read())
                {
                    Sekcija a = new Sekcija();
                    a.id = getReader.GetInt32(0);
                    a.ime = getReader.GetString(1);

                    sekcije.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return sekcije;
        }
    }
}
