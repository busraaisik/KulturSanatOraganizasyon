using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class BiletDAL
    {
        DbConnection db =
            new DbConnection();
        public DataTable SiparisleriListele()
        {
            string sql =
        @"SELECT
b.BiletID,
o.OrganizasyonAdi,
b.BiletTuru,
b.Fiyat,
k.KoltukNo
FROM Bilet b
INNER JOIN Organizasyon o
ON b.OrganizasyonID = o.OrganizasyonID
INNER JOIN Koltuk k
ON b.KoltukID = k.KoltukID";

            MySqlDataAdapter da =
                new MySqlDataAdapter(
                    sql,
                    db.Baglanti());

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
        public void BiletEkle(
            string biletTuru,
            decimal fiyat,
            int musteriID,
            int organizasyonID,
            int koltukID
        )
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "BiletEkle",
                    db.Baglanti()
                );

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_biletTuru",
                biletTuru
            );

            cmd.Parameters.AddWithValue(
                "p_fiyat",
                fiyat
            );

            cmd.Parameters.AddWithValue(
                "p_musteriID",
                musteriID
            );

            cmd.Parameters.AddWithValue(
                "p_organizasyonID",
                organizasyonID
            );

            cmd.Parameters.AddWithValue(
                "p_koltukID",
                koltukID
            );

            cmd.ExecuteNonQuery();
        }
        public decimal FiyatGetir(
    int organizasyonID,
    string biletTuru)
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    @"SELECT Fiyat
              FROM BiletFiyat
              WHERE OrganizasyonID = @id
              AND BiletTuru = @tur",
                    db.Baglanti());

            cmd.Parameters.AddWithValue(
                "@id",
                organizasyonID);

            cmd.Parameters.AddWithValue(
                "@tur",
                biletTuru);

            object sonuc =
                cmd.ExecuteScalar();

            if (sonuc != null)
                return Convert.ToDecimal(sonuc);

            return 0;
        }
    }
}
