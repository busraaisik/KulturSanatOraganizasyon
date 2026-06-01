using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulturSanat.Entity
{
    public class Salon
    {
        public int SalonID { get; set; }

        public string SalonAdi { get; set; }

        public int Kapasite { get; set; }

        public int MekanID { get; set; }
    }
}
