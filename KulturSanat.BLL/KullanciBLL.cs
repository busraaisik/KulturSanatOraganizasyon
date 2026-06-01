using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class KullaniciBLL
    {
        KullaniciDAL dal =
            new KullaniciDAL();

        public DataTable GirisYap(
            string kullaniciAdi,
            string sifre
        )
        {
            return dal.GirisYap(
                kullaniciAdi,
                sifre
            );
        }
    }
}
