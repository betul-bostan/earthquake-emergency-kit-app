using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepremCantasiApp
{
    public partial class Form1 : Form
    {
        Canta canta = new Canta();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtMalzemeAd.Text.Trim();
            int adet = (int)nudAdet.Value;

            if (string.IsNullOrEmpty(ad) || adet < 1)
            {
                lblDurum.Text = "Lütfen geçerli bir malzeme adı ve adet girin.";
                return;
            }

            Malzeme m = new Malzeme(ad, adet);
            canta.MalzemeEkle(m);
            lstMalzemeler.Items.Add(m);

            txtMalzemeAd.Clear();
            nudAdet.Value = 1;
            lblDurum.Text = $"{m.Ad} eklendi.";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedItem is Malzeme secilen)
            {
                canta.MalzemeCikar(secilen);
                lstMalzemeler.Items.Remove(secilen);
                lblDurum.Text = $"{secilen.Ad} silindi.";
            }
            else
            {
                lblDurum.Text = "Lütfen bir malzeme seçin.";
            }

        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            int malzemeSayisi = canta.MalzemeListesi.Count;
            if (malzemeSayisi >= 5)
            {
                lblDurum.Text = $"Çantanız hazır görünüyor. {malzemeSayisi} malzeme var.";
            }
            else
            {
                lblDurum.Text = $"Çantanız eksik olabilir. {malzemeSayisi} malzeme var.";
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 30000; // 30 saniye
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Malzeme m in canta.MalzemeListesi)
            {
                if ((DateTime.Now - m.EklenmeTarihi).TotalDays > 30)
                {
                    MessageBox.Show($"{m.Ad} uzun süredir güncellenmedi. Kontrol edin!", "Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
