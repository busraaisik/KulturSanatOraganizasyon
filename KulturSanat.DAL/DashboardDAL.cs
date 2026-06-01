using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KulturSanat.DAL
{
    public class DashboardDAL
    {
        DbConnection db =
            new DbConnection();

        public int ToplamOrganizasyon()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                "SELECT COUNT(*) FROM Organizasyon",
                db.Baglanti());

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }

        public int ToplamBilet()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                "SELECT COUNT(*) FROM Bilet",
                db.Baglanti());

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }

        public decimal ToplamGelir()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                "SELECT IFNULL(SUM(Fiyat),0) FROM Bilet",
                db.Baglanti());

            return Convert.ToDecimal(
                cmd.ExecuteScalar());
        }
    }
}
