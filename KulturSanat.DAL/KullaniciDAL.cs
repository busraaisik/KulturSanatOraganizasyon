using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KulturSanat.DAL
{
    public class KullaniciDAL
    {
        DbConnection db = new DbConnection();

        public DataTable GirisYap(
            string kullaniciAdi,
            string sifre
        )
        {
            MySqlCommand cmd =
                new MySqlCommand(
                    "KullaniciGiris",
                    db.Baglanti()
                );

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_kullaniciAdi",
                kullaniciAdi
            );

            cmd.Parameters.AddWithValue(
                "p_sifre",
                sifre
            );

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}