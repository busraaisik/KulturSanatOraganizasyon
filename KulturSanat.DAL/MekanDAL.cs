using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class MekanDAL
    {
        DbConnection db = new DbConnection();

        public DataTable Listele()
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "MekanListele",
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
            string mekanAdi,
            string adres)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "MekanEkle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_MekanAdi",
                mekanAdi);

            cmd.Parameters.AddWithValue(
                "p_Adres",
                adres);

            cmd.ExecuteNonQuery();
        }

        public void Guncelle(
            int mekanID,
            string mekanAdi,
            string adres)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "MekanGuncelle",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_MekanID",
                mekanID);

            cmd.Parameters.AddWithValue(
                "p_MekanAdi",
                mekanAdi);

            cmd.Parameters.AddWithValue(
                "p_Adres",
                adres);

            cmd.ExecuteNonQuery();
        }

        public void Sil(int mekanID)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "MekanSil",
                    db.Baglanti());

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_MekanID",
                mekanID);

            cmd.ExecuteNonQuery();
        }
    }
}
