using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class SalonBLL
    {
        SalonDAL dal =
            new SalonDAL();
        public DataTable MekanaGoreSalonlar(int mekanID)
        {
            return dal.MekanaGoreSalonlar(
                mekanID);
        }

        public DataTable Listele()
        {
            return dal.Listele();
        }

        public void Ekle(
            string salonAdi,
            int kapasite,
            int mekanID)
        {
            dal.Ekle(
                salonAdi,
                kapasite,
                mekanID);
        }

        public void Guncelle(
            int salonID,
            string salonAdi,
            int kapasite,
            int mekanID)
        {
            dal.Guncelle(
                salonID,
                salonAdi,
                kapasite,
                mekanID);
        }

        public void Sil(int salonID)
        {
            dal.Sil(salonID);
        }
    }
}

