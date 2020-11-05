namespace MobilDogrulamaAPI.Test
{
    partial class FrmNumaraAl
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
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(61, 69);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(285, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Api Key:";
            // 
            // cmbServ
            // 
            this.cmbServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServ.FormattingEnabled = true;
            this.cmbServ.Location = new System.Drawing.Point(61, 39);
            this.cmbServ.Name = "cmbServ";
            this.cmbServ.Size = new System.Drawing.Size(285, 21);
            this.cmbServ.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Servis:";
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(61, 12);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(285, 21);
            this.cmbCat.TabIndex = 5;
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.cmbCat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori:";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(257, 95);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(89, 29);
            this.btnSatinAl.TabIndex = 8;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(12, 145);
            this.txtNumara.Multiline = true;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(334, 114);
            this.txtNumara.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numara Bilgileri:";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(107, 294);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(239, 20);
            this.txtKod.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doğrulama Kodu:";
            // 
            // btnIptal
            // 
            this.btnIptal.ForeColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(12, 265);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(59, 23);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FrmNumaraAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 329);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.cmbServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label1);
            this.Name = "FrmNumaraAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numara Al";
            this.Load += new System.EventHandler(this.FrmNumaraAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIptal;
    }
}