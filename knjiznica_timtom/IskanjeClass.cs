using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class IskanjeClass
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public List<Knjiga> GetAllBooksSearch(string search)
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, r1.state FROM books b LEFT OUTER JOIN (SELECT book_id, MAX(id) AS latest FROM rents GROUP BY book_id) AS rent ON rent.book_id = b.id LEFT OUTER JOIN rents r1 ON rent.book_id = r1.book_id AND r1.id = rent.latest " +
                    "WHERE (UPPER(b.author) LIKE '%"+ search + "%') OR (UPPER(b.title) LIKE '%" + search + "%') OR (CAST(b.year AS TEXT) LIKE '%" + search + "%') OR (CAST(b.id AS TEXT) LIKE '%" + search + "%') OR (UPPER(b.publisher) LIKE '%" + search + "%') " +
                    "GROUP BY b.id";

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

        public List<Knjiga> GetAllBooksSearchWithSection(string search, int id)
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, r1.state FROM books b LEFT OUTER JOIN (SELECT book_id, MAX(id) AS latest FROM rents GROUP BY book_id) AS rent ON rent.book_id = b.id LEFT OUTER JOIN rents r1 ON rent.book_id = r1.book_id AND r1.id = rent.latest " +
                    "WHERE (section_id = "+ id +") AND ((UPPER(b.author) LIKE '%" + search + "%') OR (UPPER(b.title) LIKE '%" + search + "%') OR (CAST(b.year AS TEXT) LIKE '%" + search + "%') OR (CAST(b.id AS TEXT) LIKE '%" + search + "%') OR (UPPER(b.publisher) LIKE '%" + search + "%')) " +
                    "GROUP BY b.id";

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

        public List<Knjiga> GetAllAvaliableBooksSearch(string search)
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, r1.state FROM books b LEFT OUTER JOIN (SELECT book_id, MAX(id) AS latest FROM rents GROUP BY book_id) AS rent ON rent.book_id = b.id LEFT OUTER JOIN rents r1 ON rent.book_id = r1.book_id AND r1.id = rent.latest " +
                    "WHERE (UPPER(b.author) LIKE '%" + search + "%') OR (UPPER(b.title) LIKE '%" + search + "%') OR (CAST(b.year AS TEXT) LIKE '%" + search + "%') OR (CAST(b.id AS TEXT) LIKE '%" + search + "%') OR (UPPER(b.publisher) LIKE '%" + search + "%') " +
                    "GROUP BY b.id";

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

                    if (a.zasedena == 0)
                        list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }

        public List<Knjiga> GetAllAvaliableBooksSearchWithSection(string search, int id)
        {
            List<Knjiga> list = new List<Knjiga>();

            conn.Open();

            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "SELECT b.*, r1.state FROM books b LEFT OUTER JOIN (SELECT book_id, MAX(id) AS latest FROM rents GROUP BY book_id) AS rent ON rent.book_id = b.id LEFT OUTER JOIN rents r1 ON rent.book_id = r1.book_id AND r1.id = rent.latest " +
                    "WHERE (section_id = " + id + ") AND ((UPPER(b.author) LIKE '%" + search + "%') OR (UPPER(b.title) LIKE '%" + search + "%') OR (CAST(b.year AS TEXT) LIKE '%" + search + "%') OR (CAST(b.id AS TEXT) LIKE '%" + search + "%') OR (UPPER(b.publisher) LIKE '%" + search + "%')) " +
                    "GROUP BY b.id";

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

                    if (a.zasedena == 0)
                        list.Add(a);
                }

                com.Dispose();
            }

            conn.Close();

            return list;
        }
    }
}
