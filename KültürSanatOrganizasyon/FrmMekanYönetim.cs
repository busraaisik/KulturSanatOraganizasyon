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
    public partial class FrmMekanYönetim : Form
    {
        MekanBLL bll = new MekanBLL();

        int secilenID = 0;
        public FrmMekanYönetim()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bll.Ekle(
                txtMekanAdi.Text,
                txtAdres.Text);

            MessageBox.Show(
                "Mekan eklendi.");

            dataGridView1.DataSource =
                bll.Listele();
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
              bll.Listele();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            bll.Sil(secilenID);

            MessageBox.Show(
                "Mekan silindi.");

            dataGridView1.DataSource =
                bll.Listele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            bll.Guncelle(
               secilenID,
               txtMekanAdi.Text,
               txtAdres.Text);

            MessageBox.Show(
                "Mekan güncellendi.");

            dataGridView1.DataSource =
                bll.Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID =
                Convert.ToInt32(
                    dataGridView1.CurrentRow
                    .Cells["MekanID"]
                    .Value);

            txtMekanAdi.Text =
                dataGridView1.CurrentRow
                .Cells["MekanAdi"]
                .Value.ToString();

            txtAdres.Text =
                dataGridView1.CurrentRow
                .Cells["Adres"]
                .Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
