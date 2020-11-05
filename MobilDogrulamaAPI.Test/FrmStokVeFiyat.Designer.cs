namespace MobilDogrulamaAPI.Test
{
    partial class FrmStokVeFiyat
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
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.cmbServ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori:";
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(67, 6);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(242, 21);
            this.cmbCat.TabIndex = 1;
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.cmbCat_SelectedIndexChanged);
            // 
            // cmbServ
            // 
            this.cmbServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServ.FormattingEnabled = true;
            this.cmbServ.Location = new System.Drawing.Point(67, 33);
            this.cmbServ.Name = "cmbServ";
            this.cmbServ.Size = new System.Drawing.Size(242, 21);
            this.cmbServ.TabIndex = 3;
            this.cmbServ.SelectedIndexChanged += new System.EventHandler(this.cmbServ_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servis:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFiyat.Location = new System.Drawing.Point(10, 92);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(277, 25);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Seçtiğiniz Servisin Fiyatı: ... TL";
            // 
            // FrmStokVeFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 135);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.cmbServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.label1);
            this.Name = "FrmStokVeFiyat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Servis\'e Ait Stok ve Fiyat";
            this.Load += new System.EventHandler(this.FrmStokVeFiyat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.ComboBox cmbServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiyat;
    }
}