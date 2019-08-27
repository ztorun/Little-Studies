using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VTIslemleri;

namespace SinemaOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        //Kullanıcı Girişi yapılırsa sadece bilet satış sayfasına gidebilir. yönetici olmadan diğer hiçbir şeyi yapamaz.
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void AnafORMM_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
        }

        byte i;
        private void timer1_Tick(object sender, EventArgs e)
        {

            i++;
            if (i == 1)
                pictureBox1.Image = Properties.Resources._1;
            else if (i == 2)
                pictureBox1.Image = Properties.Resources._2;
            else if (i == 3)
                pictureBox1.Image = Properties.Resources._3;
            else if (i == 4)
                pictureBox1.Image = Properties.Resources._4;
            else if (i == 5)
                pictureBox1.Image = Properties.Resources._5;
            else if (i == 6)
                pictureBox1.Image = Properties.Resources._6;
            else if (i == 7)
                pictureBox1.Image = Properties.Resources._7;
            else if (i == 8)
            {
                pictureBox1.Image = Properties.Resources._8;
                i = 0;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_tc.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız...");
                return;
            }
            
            DataTable dt_sonuc = vt.Select(@"select kullanici_id,tc, kullaniciAd,kullaniciSoyad, sifre,yoneticiMikullaniciMi
                                         from tbl_Kullanici where tc ='"+tx_tc.Text+"' and sifre='"+tx_sifre.Text+"'");
            MessageBox.Show("kontrol yapılıyor: ");
            
            if (dt_sonuc.Rows.Count == 0)
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            else
            {
                MessageBox.Show("şifreniz doğru");
                // yonetici olup olmadığını kontrol ettir, değilse bilet satışa yönelt
                if (dt_sonuc.Rows[0][5].ToString() == "1")
                {
                    MessageBox.Show("Yönetici Girişi Yapıldı:" + dt_sonuc.Rows[0][2].ToString() + " " + dt_sonuc.Rows[0][3].ToString());
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Yapıldı:" + dt_sonuc.Rows[0][2].ToString() + " " + dt_sonuc.Rows[0][3].ToString());
                }
              /*  AnaForm f = new AnaForm();
                this.Hide();
                f.Text = "Ana Form -[ Kullanıcı: " + dt_sonuc.Rows[0][1].ToString() + " " + dt_sonuc.Rows[0][2].ToString() + " ]";
                f.kg = this;
                f.Show();*/
            }
        }

    }
}
