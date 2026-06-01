using KulturSanat.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulturSanat.BLL
{
    public class BiletBLL
    {
        BiletDAL dal =
            new BiletDAL();
        public DataTable SiparisleriListele()
        {
            return dal.SiparisleriListele();
        }
        public decimal FiyatGetir(
    int organizasyonID,
    string biletTuru)
        {
            return dal.FiyatGetir(
                organizasyonID,
                biletTuru);
        }

        public void BiletEkle(
            string biletTuru,
            decimal fiyat,
            int musteriID,
            int organizasyonID,
            int koltukID
        )
        {
            dal.BiletEkle(
                biletTuru,
                fiyat,
                musteriID,
                organizasyonID,
                koltukID
            );
        }
    }
}
