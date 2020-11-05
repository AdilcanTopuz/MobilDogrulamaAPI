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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKategoriler cat = new FrmKategoriler();
            cat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmServisler servisler = new FrmServisler();
            servisler.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStokVeFiyat sf = new FrmStokVeFiyat();
            sf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBakiye bakiye = new FrmBakiye();
            bakiye.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmNumaraAl num = new FrmNumaraAl();
            num.ShowDialog();
        }
    }
}
