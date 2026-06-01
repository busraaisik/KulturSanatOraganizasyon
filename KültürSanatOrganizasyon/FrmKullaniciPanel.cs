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
    public partial class FrmKullaniciPanel : Form
    {
        OrganizasyonBLL bll = new OrganizasyonBLL();
        private void OrganizasyonlariGetir()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt =
                bll.Listele();

            foreach (DataRow row in dt.Rows)
            {
                KartOlustur(
                    row["OrganizasyonAdi"]
                        .ToString(),

                    row["MekanAdi"]
                        .ToString(),

                    row["SalonAdi"]
                        .ToString(),

                    Convert.ToDateTime(
                        row["OrganizasyonTarihi"])
                        .ToShortDateString(),

                    Convert.ToInt32(
                        row["OrganizasyonID"])
                );
            }
        }
        private void KartOlustur(
    string ad,
    string mekan,
    string salon,
    string tarih,
    int organizasyonID)
        {
            Panel kart = new Panel();

            kart.Width = 250;
            kart.Height = 140;

            kart.BorderStyle =
                BorderStyle.FixedSingle;

            Label lblAd = new Label();
            lblAd.Text = " " + ad;
            lblAd.Top = 10;
            lblAd.Left = 10;
            lblAd.AutoSize = true;

            Label lblMekan = new Label();
            lblMekan.Text = "📍 " + mekan;
            lblMekan.Top = 40;
            lblMekan.Left = 10;
            lblMekan.AutoSize = true;


            Label lblTarih = new Label();
            lblTarih.Text = "📅 " + tarih;
            lblTarih.Top = 70;
            lblTarih.Left = 10;
            lblTarih.AutoSize = true;

            Button btn = new Button();
            btn.Text = " 🎟️ Bilet Al";
            btn.Width = 100;
            btn.Top = 100;
            btn.Left = 10;

            btn.Tag = organizasyonID;
            btn.AccessibleName = ad;
            btn.AccessibleDescription =
    mekan + "|" + salon;


            btn.Click += Btn_Click;

            kart.Controls.Add(lblAd);
            kart.Controls.Add(lblMekan);
            kart.Controls.Add(lblTarih);
            kart.Controls.Add(btn);

            flowLayoutPanel1.Controls.Add(kart);
        }
        public FrmKullaniciPanel()
        {
            InitializeComponent();
        }

        private void FrmKullaniciPanel_Load(object sender, EventArgs e)
        {
            OrganizasyonlariGetir();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt =
                bll.Listele();

            foreach (DataRow row in dt.Rows)
            {
                KartOlustur(
                    row["OrganizasyonAdi"].ToString(),
                    row["MekanAdi"].ToString(),
                    row["SalonAdi"].ToString(),
                    Convert.ToDateTime(
                        row["OrganizasyonTarihi"])
                        .ToShortDateString(),
                    Convert.ToInt32(
                        row["OrganizasyonID"])
                );
            }
        }
        private void Btn_Click(
    object sender,
    EventArgs e)
        {
            Button btn =
                (Button)sender;

            int organizasyonID =
                Convert.ToInt32(btn.Tag);

            string organizasyonAdi =
    btn.AccessibleName;

            string[] bilgiler =
                btn.AccessibleDescription
                .Split('|');

            string mekanAdi =
                bilgiler[0];

            string salonAdi =
                bilgiler[1];

            lblMekanAdi frm =
                new lblMekanAdi(
                    organizasyonID,
                    organizasyonAdi,
                    mekanAdi,
                    salonAdi);

            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in
        flowLayoutPanel1.Controls)
            {
                Panel kart =
                    c as Panel;

                if (kart == null)
                    continue;

                Label lbl =
                    kart.Controls[0]
                    as Label;

                kart.Visible =
                    lbl.Text.ToLower()
                    .Contains(
                        txtAra.Text
                        .ToLower());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frm =
       new FrmLogin();

            frm.Show();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
