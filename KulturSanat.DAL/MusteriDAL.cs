using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class MusteriDAL
    {
        DbConnection db = new DbConnection();

        public DataTable MusterileriListele()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "MusterileriListele",
                    db.Baglanti()
                );

            cmd.CommandType =
                CommandType.StoredProcedure;

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}