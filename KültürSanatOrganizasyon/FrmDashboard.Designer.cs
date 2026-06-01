namespace KültürSanatOrganizasyon
{
    partial class FrmDashboard
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
            this.panelOrg = new System.Windows.Forms.Panel();
            this.panelBilet = new System.Windows.Forms.Panel();
            this.panelGelir = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamOrganizasyon = new System.Windows.Forms.Label();
            this.lblToplamBilet = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.panelOrg.SuspendLayout();
            this.panelBilet.SuspendLayout();
            this.panelGelir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrg
            // 
            this.panelOrg.BackColor = System.Drawing.Color.White;
            this.panelOrg.Controls.Add(this.lblToplamOrganizasyon);
            this.panelOrg.Controls.Add(this.label1);
            this.panelOrg.Location = new System.Drawing.Point(102, 261);
            this.panelOrg.Name = "panelOrg";
            this.panelOrg.Size = new System.Drawing.Size(250, 150);
            this.panelOrg.TabIndex = 6;
            // 
            // panelBilet
            // 
            this.panelBilet.BackColor = System.Drawing.Color.White;
            this.panelBilet.Controls.Add(this.lblToplamBilet);
            this.panelBilet.Controls.Add(this.label2);
            this.panelBilet.Location = new System.Drawing.Point(423, 261);
            this.panelBilet.Name = "panelBilet";
            this.panelBilet.Size = new System.Drawing.Size(250, 150);
            this.panelBilet.TabIndex = 7;
            // 
            // panelGelir
            // 
            this.panelGelir.BackColor = System.Drawing.Color.White;
            this.panelGelir.Controls.Add(this.lblToplamGelir);
            this.panelGelir.Controls.Add(this.label3);
            this.panelGelir.Location = new System.Drawing.Point(743, 261);
            this.panelGelir.Name = "panelGelir";
            this.panelGelir.Size = new System.Drawing.Size(250, 150);
            this.panelGelir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "📅 Organizasyon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "🎟️ Satılan Bilet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "💰 Toplam Gelir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(104, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "📊 Yönetim Paneli";
            // 
            // lblToplamOrganizasyon
            // 
            this.lblToplamOrganizasyon.AutoSize = true;
            this.lblToplamOrganizasyon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOrganizasyon.Location = new System.Drawing.Point(103, 68);
            this.lblToplamOrganizasyon.Name = "lblToplamOrganizasyon";
            this.lblToplamOrganizasyon.Size = new System.Drawing.Size(32, 38);
            this.lblToplamOrganizasyon.TabIndex = 1;
            this.lblToplamOrganizasyon.Text = "1";
            // 
            // lblToplamBilet
            // 
            this.lblToplamBilet.AutoSize = true;
            this.lblToplamBilet.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBilet.Location = new System.Drawing.Point(101, 68);
            this.lblToplamBilet.Name = "lblToplamBilet";
            this.lblToplamBilet.Size = new System.Drawing.Size(32, 38);
            this.lblToplamBilet.TabIndex = 2;
            this.lblToplamBilet.Text = "1";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelir.Location = new System.Drawing.Point(67, 68);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(121, 38);
            this.lblToplamGelir.TabIndex = 3;
            this.lblToplamGelir.Text = " 1500 TL";
            this.lblToplamGelir.Click += new System.EventHandler(this.lblToplamGelir_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1104, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelGelir);
            this.Controls.Add(this.panelBilet);
            this.Controls.Add(this.panelOrg);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelOrg.ResumeLayout(false);
            this.panelOrg.PerformLayout();
            this.panelBilet.ResumeLayout(false);
            this.panelBilet.PerformLayout();
            this.panelGelir.ResumeLayout(false);
            this.panelGelir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBilet;
        private System.Windows.Forms.Panel panelGelir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamOrganizasyon;
        private System.Windows.Forms.Label lblToplamBilet;
        private System.Windows.Forms.Label lblToplamGelir;
    }
}