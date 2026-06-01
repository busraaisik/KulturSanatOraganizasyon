namespace KültürSanatOrganizasyon
{
    partial class FrmAdminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOrgnizasyonlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOrgnizasyonlar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 701);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(33, 597);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(33, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Siparişler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(33, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "Salonlar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(33, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mekanlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrgnizasyonlar
            // 
            this.btnOrgnizasyonlar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrgnizasyonlar.Location = new System.Drawing.Point(33, 180);
            this.btnOrgnizasyonlar.Name = "btnOrgnizasyonlar";
            this.btnOrgnizasyonlar.Size = new System.Drawing.Size(161, 45);
            this.btnOrgnizasyonlar.TabIndex = 1;
            this.btnOrgnizasyonlar.Text = "Organizasyonlar";
            this.btnOrgnizasyonlar.UseVisualStyleBackColor = true;
            this.btnOrgnizasyonlar.Click += new System.EventHandler(this.btnOrgnizasyonlar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(33, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelIcerik
            // 
            this.panelIcerik.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(237, 0);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Size = new System.Drawing.Size(1152, 701);
            this.panelIcerik.TabIndex = 2;
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 701);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminPanel";
            this.Text = "FrmAdminPanel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOrgnizasyonlar;
        private System.Windows.Forms.Button button7;
    }
}