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
    public partial class FrmOdeme : Form
    {
        BiletBLL bll = new BiletBLL();
        decimal fiyat;
        string biletTuru;
        int organizasyonID;
        int koltukID;
        public FrmOdeme(
    decimal gelenFiyat,
    string gelenBiletTuru,
    int gelenOrganizasyonID,
    int gelenKoltukID)
        {
            InitializeComponent();

            fiyat = gelenFiyat;
            biletTuru = gelenBiletTuru;
            organizasyonID = gelenOrganizasyonID;
            koltukID = gelenKoltukID;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            lblTutar.Text =
        fiyat + " TL";

        }

        private void btnOdemeTamamla_Click(object sender, EventArgs e)
        {
            if (txtKartSahibi.Text == "")
            {
                MessageBox.Show(
                    "Kart sahibi giriniz.");
                return;
            }

            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show(
                    "CVV hatalı.");
                return;
            }
            if (txtKartNo.Text.Length < 16)
            {
                MessageBox.Show(
                    "Kart numarası hatalı!");
                return;
            }

            int musteriID = 1;

            bll.BiletEkle(
                biletTuru,
                fiyat,
                musteriID,
                organizasyonID,
                koltukID
            );

            MessageBox.Show(
                "Ödeme başarılı!\nBilet oluşturuldu.");

            this.Close();
        }
    }
}
