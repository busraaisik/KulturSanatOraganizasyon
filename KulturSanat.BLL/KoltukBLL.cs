using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class KoltukBLL
    {
        KoltukDAL dal =
            new KoltukDAL();

        public void Ekle(
    int siraNo,
    int koltukNo,
    int salonID)
        {
            dal.Ekle(
                siraNo,
                koltukNo,
                salonID);
        }
        public DataTable BosKoltuklar(
            int organizasyonID
        )
        {
            return dal.BosKoltuklar(
                organizasyonID
            );
        }
    }
}
