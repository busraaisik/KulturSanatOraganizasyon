using KulturSanat.BLL;
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
    public partial class FrmSiparisler : Form
    {
        BiletBLL bll =
    new BiletBLL();
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        private void SiparisleriGetir()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt =
                bll.SiparisleriListele();

            foreach (DataRow row in dt.Rows)
            {
                SiparisKartOlustur(
                    row["OrganizasyonAdi"]
                        .ToString(),

                    row["BiletTuru"]
                        .ToString(),

                    row["KoltukNo"]
                        .ToString(),

                    Convert.ToDecimal(
                        row["Fiyat"])
                );
            }
        }
        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            SiparisleriGetir();
        }
        private void SiparisKartOlustur(
    string organizasyon,
    string tur,
    string koltuk,
    decimal fiyat)
        {
            Panel kart =
                new Panel();

            kart.Width = 900;
            kart.Height = 90;

            kart.BackColor =
                Color.White;

            kart.BorderStyle =
                BorderStyle.FixedSingle;

            Label lblOrg =
                new Label();

            lblOrg.Text =
                "🎭 " + organizasyon;

            lblOrg.Font =
                new Font(
                    "Segoe UI",
                    14,
                    FontStyle.Bold);

            lblOrg.Location =
                new Point(15, 15);

            lblOrg.AutoSize =
                true;

            Label lblTur =
                new Label();

            lblTur.Text =
                "🏷️ " + tur;

            lblTur.Location =
                new Point(15, 50);

            lblTur.AutoSize =
                true;

            Label lblKoltuk =
                new Label();

            lblKoltuk.Text =
                "💺 " + koltuk;

            lblKoltuk.Location =
                new Point(250, 50);

            lblKoltuk.AutoSize =
                true;

            Label lblFiyat =
                new Label();

            lblFiyat.Text =
                "💰 " + fiyat + " TL";

            lblFiyat.Location =
                new Point(450, 50);

            lblFiyat.AutoSize =
                true;

            Label lblDurum =
                new Label();

            lblDurum.Text =
                "ÖDENDİ";

            lblDurum.ForeColor =
                Color.Green;

            lblDurum.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            lblDurum.Location =
                new Point(780, 15);

            lblDurum.AutoSize =
                true;

            kart.Controls.Add(lblOrg);
            kart.Controls.Add(lblTur);
            kart.Controls.Add(lblKoltuk);
            kart.Controls.Add(lblFiyat);
            kart.Controls.Add(lblDurum);

            flowLayoutPanel1.Controls.Add(kart);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SiparisleriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aranan =
     txtAra.Text.ToLower();

            foreach (Control c in
                flowLayoutPanel1.Controls)
            {
                Panel kart =
                    c as Panel;

                if (kart == null)
                    continue;

                Label lblOrg =
                    kart.Controls[0]
                    as Label;

                kart.Visible =
                    lblOrg.Text
                    .ToLower()
                    .Contains(aranan);
            }
        }
    }
}
