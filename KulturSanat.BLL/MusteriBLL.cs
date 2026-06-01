using KulturSanat.DAL;
using System.Data;

namespace KulturSanat.BLL
{
    public class MusteriBLL
    {
        MusteriDAL dal = new MusteriDAL();

        public DataTable Listele()
        {
            return dal.MusterileriListele();
        }
    }
}