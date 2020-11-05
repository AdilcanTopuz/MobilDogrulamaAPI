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
    public partial class FrmNumaraAl : Form
    {
        public FrmNumaraAl()
        {
            InitializeComponent();
        }

        private async void FrmNumaraAl_Load(object sender, EventArgs e)
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
        bool NumaraAlindi = false;
        long NumaraID = 0;
        private async void btnSatinAl_Click(object sender, EventArgs e)
        {
            try
            {
                string apikey = txtApiKey.Text;

                if (string.IsNullOrEmpty(apikey))
                {
                    MessageBox.Show("Api Key Boş Olamaz!", "UYARI");
                    return;
                }

                NumaraSiparis order = new NumaraSiparis();
                var siparis = await order.NumaraAl(apikey, int.Parse(cmbServ.SelectedValue.ToString()));
                txtNumara.Text = "";
                txtNumara.Text += "Başarılı: " + siparis.Success + Environment.NewLine;
                txtNumara.Text += "Başlık: " + siparis.Title + Environment.NewLine;
                txtNumara.Text += "Açıklama: " + siparis.Message + Environment.NewLine;
                txtNumara.Text += "Numara ID: " + siparis.NumberId + Environment.NewLine;
                txtNumara.Text += "Numara: " + siparis.Number + Environment.NewLine;
                NumaraID = siparis.NumberId;
                NumaraAlindi = true;

                await Task.Delay(25000);

                if (siparis.Success)
                {
                    NumaraSiparis sms = new NumaraSiparis();
                    var dogrulama = await sms.SmsOku(apikey, (int)NumaraID);
                    txtKod.Text = dogrulama.Code.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                if (NumaraAlindi)
                {
                    string apikey = txtApiKey.Text;

                    if (string.IsNullOrEmpty(apikey))
                    {
                        MessageBox.Show("Api Key Boş Olamaz!", "UYARI");
                        return;
                    }

                    NumaraSiparis cancel = new NumaraSiparis();
                    var iptal = await cancel.NumaraIptal(apikey, (int)NumaraID);
                    MessageBox.Show($"Success: {iptal.Success}\nTitle:{iptal.Title}\nMessage:{iptal.Message}");

                    if (iptal.Success)
                    {
                        NumaraAlindi = false;
                    }
                    else
                    {
                        MessageBox.Show("Numara İptal Edilmedi. Tekrar Deneyin");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
