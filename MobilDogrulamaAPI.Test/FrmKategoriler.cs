using System;
using System.Windows.Forms;
using MobilDogrulamaAPI;

namespace MobilDogrulamaAPI.Test
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private async void btnCat_Click(object sender, EventArgs e)
        {
            try
            {
                Kategoriler cat = new Kategoriler();
                var kategoriler = await cat.KategorileriGetir();
               
                lstCat.DisplayMember = "Name";
                lstCat.ValueMember = "Id";
                lstCat.DataSource = kategoriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstCat_Click(object sender, EventArgs e)
        {
            lblId.Text = "Seçtiğiniz Kategorinin ID'si:" + lstCat.SelectedValue;
        }
    }
}
