using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;

namespace KulturSanat.BLL
{
    public class DashboardBLL
    {
        DashboardDAL dal =
            new DashboardDAL();

        public int ToplamOrganizasyon()
        {
            return dal.ToplamOrganizasyon();
        }

        public int ToplamBilet()
        {
            return dal.ToplamBilet();
        }

        public decimal ToplamGelir()
        {
            return dal.ToplamGelir();
        }
    }
}