using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class KoltukDAL
    {
        DbConnection db =
            new DbConnection();

        public DataTable BosKoltuklar(
            int organizasyonID
        )
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "OrganizasyonaGoreBosKoltuklar",
                    db.Baglanti()
                );

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_organizasyonID",
                organizasyonID
            );

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
        public void Ekle(
    int siraNo,
    int koltukNo,
    int salonID)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "KoltukEkle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_siraNo",
                siraNo);

            cmd.Parameters.AddWithValue(
                "p_koltukNo",
                koltukNo);

            cmd.Parameters.AddWithValue(
                "p_salonID",
                salonID);

            cmd.ExecuteNonQuery();
        }
    }
}