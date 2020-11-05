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
    public partial class FrmServisler : Form
    {
        public FrmServisler()
        {
            InitializeComponent();
        }

        private async void FrmServisler_Load(object sender, EventArgs e)
        {
            try
            {
                Kategoriler cat = new Kategoriler();
                var kategoriler = await cat.KategorileriGetir();

                cmbCat.DisplayMember = "Name";
                cmbCat.ValueMember = "Id";
                cmbCat.DataSource = kategoriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Servisler services = new Servisler();
                var servisler = await services.ServisleriGetir(int.Parse(cmbCat.SelectedValue.ToString()));

                lstServices.DisplayMember = "Name";
                lstServices.ValueMember = "Id";
                lstServices.DataSource = servisler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstServices_Click(object sender, EventArgs e)
        {
            lblId.Text = "Seçtiğiniz Servisin ID'si:" + lstServices.SelectedValue;
        }
    }
}
