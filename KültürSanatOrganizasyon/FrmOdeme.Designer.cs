namespace KültürSanatOrganizasyon
{
    partial class FrmOdeme
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKartSahibi = new System.Windows.Forms.TextBox();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.txtSKT = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnOdemeTamamla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Sahibi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CVV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tutar";
            // 
            // txtKartSahibi
            // 
            this.txtKartSahibi.Location = new System.Drawing.Point(233, 85);
            this.txtKartSahibi.Name = "txtKartSahibi";
            this.txtKartSahibi.Size = new System.Drawing.Size(200, 22);
            this.txtKartSahibi.TabIndex = 5;
            // 
            // txtKartNo
            // 
            this.txtKartNo.Location = new System.Drawing.Point(233, 133);
            this.txtKartNo.MaxLength = 16;
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(200, 22);
            this.txtKartNo.TabIndex = 6;
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(233, 179);
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(80, 22);
            this.txtSKT.TabIndex = 7;
            this.txtSKT.Text = "AA/YY";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(233, 224);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(80, 22);
            this.txtCVV.TabIndex = 8;
            this.txtCVV.UseSystemPasswordChar = true;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(233, 268);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(33, 16);
            this.lblTutar.TabIndex = 9;
            this.lblTutar.Text = "0 TL";
            // 
            // btnOdemeTamamla
            // 
            this.btnOdemeTamamla.Location = new System.Drawing.Point(163, 337);
            this.btnOdemeTamamla.Name = "btnOdemeTamamla";
            this.btnOdemeTamamla.Size = new System.Drawing.Size(150, 40);
            this.btnOdemeTamamla.TabIndex = 10;
            this.btnOdemeTamamla.Text = "Ödemeyi Tamamla";
            this.btnOdemeTamamla.UseVisualStyleBackColor = true;
            this.btnOdemeTamamla.Click += new System.EventHandler(this.btnOdemeTamamla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(136, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ödeme Ekranı";
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 401);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOdemeTamamla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtSKT);
            this.Controls.Add(this.txtKartNo);
            this.Controls.Add(this.txtKartSahibi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOdeme";
            this.Text = "FrmOdeme";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKartSahibi;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.TextBox txtSKT;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnOdemeTamamla;
        private System.Windows.Forms.Label label6;
    }
}