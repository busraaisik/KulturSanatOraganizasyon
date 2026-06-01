using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class DbConnection
    {
        MySqlConnection baglanti =
            new MySqlConnection(
                "Server=localhost;Database=kultur_sanat_db;Uid= root;Pwd=0802;"
            );

        public MySqlConnection Baglanti()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            return baglanti;
        }
    }
}