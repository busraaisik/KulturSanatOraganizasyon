namespace KültürSanatOrganizasyon
{
    partial class lblMekanAdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKoltuk = new System.Windows.Forms.ComboBox();
            this.cmbBiletTuru = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrganizasyonAdi = new System.Windows.Forms.Label();
            this.lblMekanBilgisi = new System.Windows.Forms.Label();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(138, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Seç:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbKoltuk
            // 
            this.cmbKoltuk.FormattingEnabled = true;
            this.cmbKoltuk.Location = new System.Drawing.Point(310, 312);
            this.cmbKoltuk.Name = "cmbKoltuk";
            this.cmbKoltuk.Size = new System.Drawing.Size(247, 24);
            this.cmbKoltuk.TabIndex = 1;
            // 
            // cmbBiletTuru
            // 
            this.cmbBiletTuru.FormattingEnabled = true;
            this.cmbBiletTuru.Items.AddRange(new object[] {
            "VIP",
            "Normal",
            "Öğrenci"});
            this.cmbBiletTuru.Location = new System.Drawing.Point(310, 230);
            this.cmbBiletTuru.Name = "cmbBiletTuru";
            this.cmbBiletTuru.Size = new System.Drawing.Size(247, 24);
            this.cmbBiletTuru.TabIndex = 2;
            this.cmbBiletTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBiletTuru_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(310, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(138, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Organizasyon Adı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(138, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mekan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(138, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(138, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bilet Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(138, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fiyat:";
            // 
            // lblOrganizasyonAdi
            // 
            this.lblOrganizasyonAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrganizasyonAdi.Location = new System.Drawing.Point(310, 87);
            this.lblOrganizasyonAdi.Name = "lblOrganizasyonAdi";
            this.lblOrganizasyonAdi.Size = new System.Drawing.Size(247, 22);
            this.lblOrganizasyonAdi.TabIndex = 5;
            this.lblOrganizasyonAdi.UseCompatibleTextRendering = true;
            this.lblOrganizasyonAdi.Click += new System.EventHandler(this.lblOrganizasyonAdi_Click);
            // 
            // lblMekanBilgisi
            // 
            this.lblMekanBilgisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMekanBilgisi.Location = new System.Drawing.Point(310, 130);
            this.lblMekanBilgisi.Name = "lblMekanBilgisi";
            this.lblMekanBilgisi.Size = new System.Drawing.Size(247, 22);
            this.lblMekanBilgisi.TabIndex = 6;
            this.lblMekanBilgisi.UseCompatibleTextRendering = true;
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalonAdi.Location = new System.Drawing.Point(310, 179);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(247, 23);
            this.lblSalonAdi.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(307, 279);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(33, 16);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "0 TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(250, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 39);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bilet Satın Al";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblOrganizasyonAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFiyat);
            this.panel1.Controls.Add(this.lblMekanBilgisi);
            this.panel1.Controls.Add(this.lblSalonAdi);
            this.panel1.Controls.Add(this.cmbBiletTuru);
            this.panel1.Controls.Add(this.cmbKoltuk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 450);
            this.panel1.TabIndex = 10;
            // 
            // lblMekanAdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.panel1);
            this.Name = "lblMekanAdi";
            this.Text = "FrmBiletAl";
            this.Load += new System.EventHandler(this.FrmBiletAl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKoltuk;
        private System.Windows.Forms.ComboBox cmbBiletTuru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrganizasyonAdi;
        private System.Windows.Forms.Label lblMekanBilgisi;
        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}