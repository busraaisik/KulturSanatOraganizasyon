using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KültürSanatOrganizasyon
{
    public partial class FrmAdminPanel : Form
    {
        private void FormYukle(Form frm)
        {
            panelIcerik.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelIcerik.Controls.Add(frm);

            frm.Show();
        }
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmDashboard());
        }

        private void btnOrgnizasyonlar_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmOrganizasyonYonetim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmMekanYönetim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmSalonYonetim());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmSiparisler());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLogin frm =new FrmLogin();

            frm.Show();

            this.Close();
        }
    }
}
