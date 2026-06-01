
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class SalonDAL
    {
        DbConnection db = new DbConnection();

        public DataTable Listele()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SalonListele",
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

        public void Ekle(
            string salonAdi,
            int kapasite,
            int mekanID)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SalonEkle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_SalonAdi",
                salonAdi);

            cmd.Parameters.AddWithValue(
                "p_Kapasite",
                kapasite);

            cmd.Parameters.AddWithValue(
                "p_MekanID",
                mekanID);

            cmd.ExecuteNonQuery();
            MySqlCommand cmdID =
        new MySqlCommand(
            "SELECT MAX(SalonID) FROM Salon",
            db.Baglanti());

            int salonID =
                Convert.ToInt32(
                    cmdID.ExecuteScalar());

            // Kapasite kadar koltuk oluştur
            for (int i = 1; i <= kapasite; i++)
            {
                MySqlCommand cmdKoltuk =
                    new MySqlCommand(
                        @"INSERT INTO Koltuk
                (
                    SiraNo,
                    KoltukNo,
                    Durum,
                    SalonID
                )
                VALUES
                (
                    @siraNo,
                    @koltukNo,
                    'Bos',
                    @salonID
                )",
                        db.Baglanti());

                cmdKoltuk.Parameters.AddWithValue(
                    "@siraNo", 1);

                cmdKoltuk.Parameters.AddWithValue(
                    "@koltukNo", i);

                cmdKoltuk.Parameters.AddWithValue(
                    "@salonID", salonID);

                cmdKoltuk.ExecuteNonQuery();
            }
        }

        public void Guncelle(
            int salonID,
            string salonAdi,
            int kapasite,
            int mekanID)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SalonGuncelle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_SalonID",
                salonID);

            cmd.Parameters.AddWithValue(
                "p_SalonAdi",
                salonAdi);

            cmd.Parameters.AddWithValue(
                "p_Kapasite",
                kapasite);

            cmd.Parameters.AddWithValue(
                "p_MekanID",
                mekanID);

            cmd.ExecuteNonQuery();
        }

        public void Sil(int salonID)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SalonSil",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_SalonID",
                salonID);

            cmd.ExecuteNonQuery();
        }
        public DataTable MekanaGoreSalonlar(
    int mekanID
)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "SalonuMekanaGoreGetir",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_MekanID",
                mekanID);

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
