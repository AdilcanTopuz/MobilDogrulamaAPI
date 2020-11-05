using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilDogrulamaAPI.Test
{
    public partial class FrmBakiye : Form
    {
        public FrmBakiye()
        {
            InitializeComponent();
        }

        private async void btnBakiyeOgren_Click(object sender, EventArgs e)
        {
            try
            {
                string apiKey = txtApiKey.Text;
                if (string.IsNullOrEmpty(apiKey))
                {
                    MessageBox.Show("Api Key boş olamaz!", "UYARI");
                    return;
                }

                BakiyeOgren balance = new BakiyeOgren();
                var bakiye = await balance.BakiyeGetir(apiKey);

                lblBakiye.Text = "Bakiyeniz: " + bakiye.Balance + " TL'dir.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
