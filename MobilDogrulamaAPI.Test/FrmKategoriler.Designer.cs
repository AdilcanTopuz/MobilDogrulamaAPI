namespace MobilDogrulamaAPI.Test
{
    partial class FrmKategoriler
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
            this.btnCat = new System.Windows.Forms.Button();
            this.lstCat = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(13, 13);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(277, 23);
            this.btnCat.TabIndex = 0;
            this.btnCat.Text = "Kategorileri Getir";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // lstCat
            // 
            this.lstCat.FormattingEnabled = true;
            this.lstCat.Location = new System.Drawing.Point(13, 42);
            this.lstCat.Name = "lstCat";
            this.lstCat.Size = new System.Drawing.Size(275, 316);
            this.lstCat.TabIndex = 1;
            this.lstCat.Click += new System.EventHandler(this.lstCat_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblId.Location = new System.Drawing.Point(13, 365);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(268, 25);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Seçtiğiniz Kategorinin ID\'si: ...";
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 400);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstCat);
            this.Controls.Add(this.btnCat);
            this.Name = "FrmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.ListBox lstCat;
        private System.Windows.Forms.Label lblId;
    }
}

