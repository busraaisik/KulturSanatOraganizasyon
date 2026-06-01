using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class OrganizasyonBLL
    {
        OrganizasyonDAL dal =
            new OrganizasyonDAL();

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
            dal.Ekle(
                ad,
                turID,
                tarih,
                saat,
                aciklama,
                mekanID,
                salonID,
                vipFiyat,
                normalFiyat,
                ogrenciFiyat );
        }

        public DataTable Listele()
        {
            return dal.Listele();
        }
        public DataTable TurleriGetir()
        {
            return dal.TurleriGetir();
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
            dal.Guncelle(
                id,
                ad,
                turID,
                tarih,
                saat,
                aciklama,
                
                mekanID,
                salonID);
        }

        public void Sil(int id)
        {
            dal.Sil(id);
        }
    }

}
