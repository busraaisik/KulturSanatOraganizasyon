using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulturSanat.Entity
{
    public class Organizasyon
    {
        public int OrganizasyonID { get; set; }

        public string OrganizasyonAdi { get; set; }

        public DateTime OrganizasyonTarihi { get; set; }

        public TimeSpan OrganizasyonSaati { get; set; }

        public string Aciklama { get; set; }

        public int OrganizasyonTuruID { get; set; }

        public int OrganizatorID { get; set; }

        public int MekanID { get; set; }
    }
}
