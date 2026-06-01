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
    public partial class FrmLogin : Form
    {
        KullaniciBLL bll= new KullaniciBLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt =
       bll.GirisYap(
           txtKullaniciAdi.Text,
           txtSifre.Text
       );

            if (dt.Rows.Count > 0)
            {
                string rol =
                    dt.Rows[0]["Rol"].ToString();

                if (rol == "Admin")
                {
                        FrmAdminPanel frm = new FrmAdminPanel();

                    frm.Show();

                    this.Hide();
                    
                }
                else
                {
                    FrmKullaniciPanel frm =
        new FrmKullaniciPanel();

                    frm.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(
                    "Kullanıcı adı veya şifre hatalı!"
                );
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
