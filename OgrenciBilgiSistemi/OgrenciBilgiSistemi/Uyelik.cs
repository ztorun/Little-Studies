using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Uyelik : Form
    {
        public Uyelik()
        {
            InitializeComponent();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            /* Aşşağıda Eğer Textboxdaki veriler boşşsa bana messagebox ile lutfen tum bılgılerı eksık doldurunuz dedim. */
            if (txtTc.Text == "" || Txtno.Text == "" || Txtad.Text == "" || Txtsoyad.Text == "" || txtsifre.Text == "")
           
            {
                MessageBox.Show("Lütfen Tüm bilgileri Eksiksik Doldurunuz.!","Hata", MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

              else
            {

                using (var db = new Ogr_BilgiSistemiEntities())/* Değilse Yandaki veri tabanı yerini gösterdim ve db diye değşken atadım.  */
                {

                    Uye u = new Uye();/*   Uye tablosuna u degıskenı atadım ve Textboxlardaki veriler u.tc diyerek  veri tabanındaki değerlere atadım. */
                    u.Tc = txtTc.Text;
                    u.OgrenciNo = Txtno.Text;
                    u.Ad = Txtad.Text;
                    u.Soyad = Txtsoyad.Text;
                    u.Sifre = txtsifre.Text;
                    u.DogumTarih = DateTime.Parse(dateTimePicker1.Value.ToString("dd-MM-yyyy"));   /* Burda parse demimin sebebi veri tabani 12.ocak.2012 diye veri kaydetmez mesela bunu 12.01.2012 değerine cevirim u.dogumtarihi degerıne atadım.   */
                    db.Uye.Add(u); /* U degıskenını uye tablosuna ekle demişim  */
                    db.SaveChanges();  /* ve bu kısımda ıse kayettim.  */


                    Form1 form = new Form1();
                    form.Show();/* Bu kısımda ise form 1 e yonlendırsın   */
                    Hide();

                }
            }
           

        }

        private void Uyelik_Load(object sender, EventArgs e)
        {
           
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);  /*  textboxa girilen değerlerin sadece sayı olmasına yarıyor */
        }
    }
}
