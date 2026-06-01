using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class OrganizasyonDAL
    {
        DbConnection db =
            new DbConnection();

        public void Ekle(
            string ad,
            int turID,
            DateTime tarih,
            DateTime saat,
            string aciklama,
            int mekanID,
            int salonID,
            decimal vipFiyat,
            decimal normalFiyat,
            decimal ogrenciFiyat
        )
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "OrganizasyonEkle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_ad",
                ad);
            cmd.Parameters.AddWithValue(
               "p_turID",
                turID);

            cmd.Parameters.AddWithValue(
                "p_tarih",
                tarih);

            cmd.Parameters.AddWithValue(
                "p_saat",
                saat.ToString("HH:mm:ss"));

            cmd.Parameters.AddWithValue(
                "p_aciklama",
                aciklama);

            cmd.Parameters.AddWithValue(
                "p_organizadorID",
                1);

            cmd.Parameters.AddWithValue(
                "p_mekanID",
                mekanID);

            cmd.Parameters.AddWithValue(
                "p_salonID",
                salonID);

            cmd.ExecuteNonQuery();
            MySqlCommand idCmd =
        new MySqlCommand(
        "SELECT MAX(OrganizasyonID) FROM Organizasyon",
        db.Baglanti());

            int organizasyonID =
                Convert.ToInt32(
                    idCmd.ExecuteScalar());
            MySqlCommand vipCmd =
    new MySqlCommand(
        "BiletFiyatEkle",
        db.Baglanti());

            vipCmd.CommandType =
                CommandType.StoredProcedure;

            vipCmd.Parameters.AddWithValue(
                "p_organizasyonID",
                organizasyonID);

            vipCmd.Parameters.AddWithValue(
                "p_biletTuru",
                "VIP");

            vipCmd.Parameters.AddWithValue(
                "p_fiyat",
                vipFiyat);

            vipCmd.ExecuteNonQuery();
            MySqlCommand normalCmd =
    new MySqlCommand(
        "BiletFiyatEkle",
        db.Baglanti());

            normalCmd.CommandType =
                CommandType.StoredProcedure;

            normalCmd.Parameters.AddWithValue(
                "p_organizasyonID",
                organizasyonID);

            normalCmd.Parameters.AddWithValue(
                "p_biletTuru",
                "Normal");

            normalCmd.Parameters.AddWithValue(
                "p_fiyat",
                normalFiyat);

            normalCmd.ExecuteNonQuery();
            MySqlCommand ogrenciCmd =
    new MySqlCommand(
        "BiletFiyatEkle",
        db.Baglanti());

            ogrenciCmd.CommandType =
                CommandType.StoredProcedure;

            ogrenciCmd.Parameters.AddWithValue(
                "p_organizasyonID",
                organizasyonID);

            ogrenciCmd.Parameters.AddWithValue(
                "p_biletTuru",
                "Öğrenci");

            ogrenciCmd.Parameters.AddWithValue(
                "p_fiyat",
                ogrenciFiyat);

            ogrenciCmd.ExecuteNonQuery();
        }

        public DataTable Listele()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "OrganizasyonListele",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
        public DataTable TurleriGetir()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SELECT * FROM OrganizasyonTuru",
                    db.Baglanti());

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
        public void Guncelle(
    int id,
    string ad,
    int turID,
    DateTime tarih,
    DateTime saat,
    string aciklama,
    
    int mekanID,
    int salonID
)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "OrganizasyonGuncelle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", id);
            cmd.Parameters.AddWithValue("p_ad", ad);
            cmd.Parameters.AddWithValue("p_turID", turID);
            cmd.Parameters.AddWithValue("p_tarih", tarih);
            cmd.Parameters.AddWithValue("p_saat", saat.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("p_aciklama", aciklama);
            
            cmd.Parameters.AddWithValue("p_mekanID", mekanID);
            cmd.Parameters.AddWithValue("p_salonID", salonID);

            cmd.ExecuteNonQuery();
        }

        public void Sil(int id)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "OrganizasyonSil",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_id",
                id);

            cmd.ExecuteNonQuery();
        }
    }
}


