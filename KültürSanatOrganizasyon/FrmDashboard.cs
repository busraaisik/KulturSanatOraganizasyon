using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KulturSanat.BLL;

namespace KültürSanatOrganizasyon
{
 
    public partial class FrmDashboard : Form
    {
        DashboardBLL bll =
    new DashboardBLL();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblToplamOrganizasyon.Text =
        bll.ToplamOrganizasyon()
        .ToString();

            lblToplamBilet.Text =
                bll.ToplamBilet()
                .ToString();

            lblToplamGelir.Text =
                bll.ToplamGelir()
                + " TL";
        }

        private void lblToplamGelir_Click(object sender, EventArgs e)
        {

        }
    }
}
