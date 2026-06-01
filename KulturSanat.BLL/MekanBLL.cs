using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class MekanBLL
    {
        MekanDAL dal =
            new MekanDAL();

        public DataTable Listele()
        {
            return dal.Listele();
        }

        public void Ekle(
            string mekanAdi,
            string adres)
        {
            dal.Ekle(
                mekanAdi,
                adres);
        }

        public void Guncelle(
            int mekanID,
            string mekanAdi,
            string adres)
        {
            dal.Guncelle(
                mekanID,
                mekanAdi,
                adres);
        }

        public void Sil(int mekanID)
        {
            dal.Sil(mekanID);
        }
    }
}
