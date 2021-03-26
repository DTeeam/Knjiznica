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
                com.CommandText = "SELECT * FROM books;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Knjiga a = new Knjiga();

                    a.inventarna_stevilka = reader.GetInt32(0);
                    a.naslov = reader.GetString(1);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
    }
}
