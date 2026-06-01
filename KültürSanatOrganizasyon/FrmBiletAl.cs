using System;
using System.Windows.Forms;
using KulturSanat.BLL;

namespace KültürSanatOrganizasyon
{
    public partial class lblMekanAdi : Form
    {
        BiletBLL bll = new BiletBLL();
        KoltukBLL koltukBLL = new KoltukBLL();

        int organizasyonID;

        public lblMekanAdi(
            int gelenOrganizasyonID,
            string organizasyonAdi,
            string mekanAdi,
            string salonAdi)
        {
            InitializeComponent();

            organizasyonID = gelenOrganizasyonID;

            lblOrganizasyonAdi.Text = organizasyonAdi;
            lblMekanBilgisi.Text = mekanAdi;
            lblSalonAdi.Text = salonAdi;
        }

        private void FrmBiletAl_Load(
            object sender,
            EventArgs e)
        {
            cmbKoltuk.DataSource =
                koltukBLL.BosKoltuklar(
                    organizasyonID);

            cmbKoltuk.DisplayMember =
                "KoltukBilgi";

            cmbKoltuk.ValueMember =
                "KoltukID";
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            string biletTuru =
                cmbBiletTuru.Text;

            int koltukID =
                Convert.ToInt32(
                    cmbKoltuk.SelectedValue);

            decimal fiyat =
        bll.FiyatGetir(
            organizasyonID,
            cmbBiletTuru.Text);

            lblFiyat.Text =
                fiyat + " TL";

            FrmOdeme frm =
     new FrmOdeme(
         fiyat,
         cmbBiletTuru.Text,
         organizasyonID,
         koltukID);

            frm.ShowDialog();


        }

        private void lblOrganizasyonAdi_Click(
            object sender,
            EventArgs e)
        {

        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {

        }

        private void label8_Click(
            object sender,
            EventArgs e)
        {

        }

        private void cmbBiletTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal fiyat =
       bll.FiyatGetir(
           organizasyonID,
           cmbBiletTuru.Text);

            MessageBox.Show(
                fiyat.ToString());

            lblFiyat.Text =
                fiyat + " TL";
        }
    }
}