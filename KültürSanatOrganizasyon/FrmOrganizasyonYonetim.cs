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
    public partial class FrmOrganizasyonYonetim : Form
    {
        int secilenID = 0;
        MekanBLL mekanBLL = new MekanBLL();
        SalonBLL salonBLL = new SalonBLL();
        OrganizasyonBLL organizasyonBLL = new OrganizasyonBLL();
        public FrmOrganizasyonYonetim()
        {
            InitializeComponent();
        }

        private void FrmOrganizasyonYonetim_Load(object sender, EventArgs e)
        {
            cmbMekan.DataSource =
        mekanBLL.Listele();

            cmbMekan.DisplayMember =
                "MekanAdi";

            cmbMekan.ValueMember =
                "MekanID";
            cmbTur.DataSource =
    organizasyonBLL.TurleriGetir();

            cmbTur.DisplayMember =
                "TurAdi";

            cmbTur.ValueMember =
                "OrganizasyonTuruID";
        }

        private void cmbMekan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMekan.SelectedValue == null)
                return;

            if (cmbMekan.SelectedValue is DataRowView)
                return;

            cmbSalon.DataSource =
                salonBLL.MekanaGoreSalonlar(
                    Convert.ToInt32(
                        cmbMekan.SelectedValue));

            cmbSalon.DisplayMember =
                "SalonAdi";

            cmbSalon.ValueMember =
                "SalonID";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = organizasyonBLL.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            organizasyonBLL.Ekle(
        txtOrganizasyonAdi.Text,
        Convert.ToInt32( cmbTur.SelectedValue),
        dtTarih.Value,
        dtSaat.Value,
        txtAciklama.Text,
        Convert.ToInt32(
            cmbMekan.SelectedValue),
        Convert.ToInt32(
            cmbSalon.SelectedValue),
         Convert.ToDecimal(txtVipFiyat.Text),
         Convert.ToDecimal(txtNormalFiyat.Text),
         Convert.ToDecimal(txtOgrenciFiyat.Text));

            MessageBox.Show(
                "Organizasyon eklendi.");

            dataGridView1.DataSource =
                organizasyonBLL.Listele();
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID =
        Convert.ToInt32(
            dataGridView1.CurrentRow
            .Cells["OrganizasyonID"]
            .Value);

            txtOrganizasyonAdi.Text =
                dataGridView1.CurrentRow
                .Cells["OrganizasyonAdi"]
                .Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            organizasyonBLL.Guncelle(
       secilenID,
       txtOrganizasyonAdi.Text,
       Convert.ToInt32(
           cmbTur.SelectedValue),
       dtTarih.Value,
       dtSaat.Value,
       txtAciklama.Text,
       
       Convert.ToInt32(
           cmbMekan.SelectedValue),
       Convert.ToInt32(
           cmbSalon.SelectedValue));

            MessageBox.Show(
                "Organizasyon güncellendi.");

            dataGridView1.DataSource =
                organizasyonBLL.Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            organizasyonBLL.Sil(
        secilenID);

            MessageBox.Show(
                "Organizasyon silindi.");

            dataGridView1.DataSource =
                organizasyonBLL.Listele();
        }
    }
}
