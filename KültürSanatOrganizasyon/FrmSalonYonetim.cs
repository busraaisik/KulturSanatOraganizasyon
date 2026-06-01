using KulturSanat.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KültürSanatOrganizasyon
{
    public partial class FrmSalonYonetim : Form
    {
        SalonBLL salonBLL = new SalonBLL();

        MekanBLL mekanBLL = new MekanBLL();

        int secilenID = 0;
        public FrmSalonYonetim()
        {
            InitializeComponent();
        }

        private void nudKapasite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMekan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSalonYonetim_Load(object sender, EventArgs e)
        {
         
        
            cmbMekan.DataSource =
                mekanBLL.Listele();

            cmbMekan.DisplayMember =
                "MekanAdi";

            cmbMekan.ValueMember =
                "MekanID";
        
    }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = salonBLL.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            salonBLL.Ekle(
       txtSalonAdi.Text,
       Convert.ToInt32(
           nudKapasite.Value),
       Convert.ToInt32(
           cmbMekan.SelectedValue));
            

            MessageBox.Show(
                "Salon eklendi.");

            dataGridView1.DataSource =
                salonBLL.Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID =
        Convert.ToInt32(
            dataGridView1.CurrentRow
            .Cells["SalonID"]
            .Value);

            txtSalonAdi.Text =
                dataGridView1.CurrentRow
                .Cells["SalonAdi"]
                .Value.ToString();

            nudKapasite.Value =
                Convert.ToDecimal(
                    dataGridView1.CurrentRow
                    .Cells["Kapasite"]
                    .Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            salonBLL.Sil(secilenID);

            MessageBox.Show(
                "Salon silindi.");

            dataGridView1.DataSource =
                salonBLL.Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            salonBLL.Guncelle(
       secilenID,
       txtSalonAdi.Text,
       Convert.ToInt32(
           nudKapasite.Value),
       Convert.ToInt32(
           cmbMekan.SelectedValue));

            MessageBox.Show(
                "Salon güncellendi.");

            dataGridView1.DataSource =
                salonBLL.Listele();
        }
    }
}
