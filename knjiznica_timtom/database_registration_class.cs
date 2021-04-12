using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica_timtom
{
    class database_registration_class
    {
        SQLiteConnection conn = new SQLiteConnection("data source=library_DB_testData.sqlite");

        public void registerUser(Admin a)
        {
            conn.Open();


            using (SQLiteCommand com = new SQLiteCommand(conn))
            {
                com.CommandText = "INSERT INTO admin_users(username, password) VALUES('" + a.upIme + "', '" + a.pass + "'); ";

                com.ExecuteNonQuery();

                com.Dispose();
            }


            conn.Close();
        }
    }
}
