using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class ClaniClass
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Clan> GetAllClani()
        {
            List<Clan> list = new List<Clan>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT * FROM users;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Clan a = new Clan();

                    a.id = reader.GetInt32(0);
                    a.ime = reader.GetString(1);
                    a.priimek = reader.GetString(2);
                    a.telefon = reader.GetString(3);
                    a.naslov = reader.GetString(4);
                    a.email = reader.GetString(5);
                    a.zapiski = reader.GetString(6);
                    
                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }

        public List<Izposoja> GetAllIzposojaForUser(int clan_id)
        {
            List<Izposoja> list = new List<Izposoja>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT * FROM rents WHERE user_id = "+ clan_id +" AND state = 1;";

                SQLiteDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Izposoja a = new Izposoja();

                    a.id = reader.GetInt32(0);
                    a.id_clana = reader.GetInt32(1);
                    a.id_knjige = reader.GetInt32(2);
                    a.stanje = reader.GetInt32(3);
                    a.datum_izposoje = reader.GetString(4);

                    list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }

        public int vrni(int id_rent)
        {
            conn.Open();

            int stanje = 1;

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE rents SET state = 0 WHERE id = "+ id_rent +";";

                com.ExecuteNonQuery();

                com.Dispose();
            }

            using (SQLiteCommand comm = new SQLiteCommand(conn))
            {
                comm.CommandText = "SELECT state FROM rents WHERE id = " + id_rent + ";";

                SQLiteDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    stanje = reader.GetInt32(0);
                }

                comm.Dispose();
            }

            conn.Close();

            return stanje;
        }

        public void posodobiClana(int id_clan, string ime, string priimek, string naslov, string tel, string email, string notes)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "UPDATE users SET name = '"+ ime + "', surname = '" + priimek + "', address = '" + naslov + "', tel = '" + tel + "', email = '" + email + "', notes = '" + notes + "' WHERE id = " + id_clan + ";";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }

        public void dodajClana(string ime, string priimek, string naslov, string tel, string email, string notes)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO users (name, surname, address, tel, email, notes) VALUES('" + ime + "', '" + priimek + "', '" + naslov + "', '" + tel + "', '" + email + "', '" + notes + "');";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }

        public void zbrisiclana(int id_clan)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "DELETE FROM users WHERE id = " + id_clan + ";";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }

        public List<Knjiga> GetAllAvaliableBooks()
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

                    if(a.zasedena == 0)
                        list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }

        public void izposodi_knjige(List<int> ids, int clan_id)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                foreach(int id in ids)
                {
                    com.CommandText = "INSERT INTO rents(user_id, book_id, state, date) VALUES("+ clan_id +", "+ id +", 1, '"+ DateTime.Now.ToString("dd/MM/yyyy") +"');";

                    com.ExecuteNonQuery();
                }
                
                com.Dispose();
            }


            conn.Close();
        }
    }
}
