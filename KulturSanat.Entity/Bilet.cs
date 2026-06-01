using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulturSanat.Entity
{
    public class Bilet
    {
        public int BiletID { get; set; }

        public string BiletTuru { get; set; }

        public decimal Fiyat { get; set; }

        public string Durum { get; set; }

        public int MusteriID { get; set; }

        public int OrganizasyonID { get; set; }

        public int KoltukID { get; set; }
    }
}
