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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtSifre.PasswordChar = (char)42;
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            /* Aşşağıda Eğer Textboxdaki veriler boşşsa bana messagebox ile lutfen tum bılgılerı eksık doldurunuz dedim. */
            if (TxtNo.Text == "" || TxtSifre.Text == "")
            {
                /*Burda ise boşsa hata mesajı verdırsın dedım.*/
                MessageBox.Show("Öğrenci No veya Şifre Giriniz!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else /*Değilse*/
            {
                using (var db = new Ogr_BilgiSistemiEntities()) /* Değilse Yandaki veri tabanı yerini gösterdim ve db diye değşken atadım.  */
                {
                   /* burda ise query diye bi değişken atayıp veritabanındakı uye tablosuna bakıcak burdakı ogrencıno TxtNo ya eşitmi diye sorduk ve veritabanındaki sifre txtsifreye eşitmi diye sormuşuz*/
                    var query = db.Uye.Where(x => x.OgrenciNo == TxtNo.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
                    if (query == null)/* query değişkeni boşsa Alttaki hatayı verdirsin.*/
                    {
                        MessageBox.Show("Hatalı Ogrenci Numarası ve Şifre Girdiniz.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                    else/*Değilse*/
                    {
                        /* Ogrencıbılgı diye bir class oluşturdum burdaki static  id  olşturuyoruz ve verı tabanındakı İdyı clasdaki id ye atıyorum orda bakiyo aynımı degılmı dıye*/
                            OgrenciBilgi.Id = query.Id;
                            OgrenciBilgi.Tc = query.Tc;
                            OgrenciBilgi.OgreniNo = query.OgrenciNo;
                            OgrenciBilgi.Ad = query.Ad;
                            OgrenciBilgi.Soyad = query.Soyad;
                            OgrenciBilgi.Sifre = query.Sifre;


                            Form2 form = new Form2();    /* ve form2 ye yönlendırıyor işlem bittikten sonra bu kod ile*/
                            form.Show();
                            Hide();
                        
                        }
                    }
                }

            }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void LnkUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Linklabel olsturdum adını LnkUye demişim buna basında uyelik formuna yonlendırcek benı */
            Uyelik form = new Uyelik();
            form.Show();
            Hide();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AkademikGiriş form1 = new AkademikGiriş();
            form1.Show();
            Hide();
        }
    }
}
