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
    public partial class FrmStokVeFiyat : Form
    {
        public FrmStokVeFiyat()
        {
            InitializeComponent();
        }

        private async void FrmStokVeFiyat_Load(object sender, EventArgs e)
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

                cmbServ.DisplayMember = "Name";
                cmbServ.ValueMember = "Id";
                cmbServ.DataSource = servisler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void cmbServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StokVeFiyatlar sf = new StokVeFiyatlar();
                var StokVeFiyat = await sf.StokVeFiyatlariGetir(int.Parse(cmbServ.SelectedValue.ToString()));
                lblFiyat.Text = "Seçtiğiniz Servisin Fiyatı:" + StokVeFiyat.Price + " TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
