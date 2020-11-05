namespace MobilDogrulamaAPI.Test
{
    partial class FrmBakiye
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
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnBakiyeOgren = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Api Key:";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(65, 10);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(285, 20);
            this.txtApiKey.TabIndex = 1;
            // 
            // btnBakiyeOgren
            // 
            this.btnBakiyeOgren.Location = new System.Drawing.Point(248, 36);
            this.btnBakiyeOgren.Name = "btnBakiyeOgren";
            this.btnBakiyeOgren.Size = new System.Drawing.Size(102, 24);
            this.btnBakiyeOgren.TabIndex = 2;
            this.btnBakiyeOgren.Text = "Bakiye Öğren";
            this.btnBakiyeOgren.UseVisualStyleBackColor = true;
            this.btnBakiyeOgren.Click += new System.EventHandler(this.btnBakiyeOgren_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBakiye.Location = new System.Drawing.Point(95, 94);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(181, 25);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "Bakiyeniz: ... TL\'dir.";
            // 
            // FrmBakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 156);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.btnBakiyeOgren);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label1);
            this.Name = "FrmBakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Button btnBakiyeOgren;
        private System.Windows.Forms.Label lblBakiye;
    }
}