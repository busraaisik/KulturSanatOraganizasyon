namespace KültürSanatOrganizasyon
{
    partial class FrmSiparisler
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaslik.Location = new System.Drawing.Point(62, 36);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(453, 65);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "🎟️ Sipariş Yönetimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(149, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "🔍 Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(200, 213);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(241, 22);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYenile.Location = new System.Drawing.Point(482, 206);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(89, 35);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "↻ Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 332);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1158, 338);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1158, 670);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaslik);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmSiparisler";
            this.Text = "FrmSiparisler";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}