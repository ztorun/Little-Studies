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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Aşşağıda Eğer Textboxdaki veriler boşşsa bana messagebox ile lutfen tum bılgılerı eksık doldurunuz dedim. */
            if (txtogrnoo.Text=="" || comboBox1.Text=="" || comboBox2.Text=="" ||  txtvize1.Text==""||
                txtvize2.Text=="" || txtfinal.Text==""  )
            {
                MessageBox.Show("Lutfen Tum bilgileri Doldurunuz.", "Hata");
            }
            else
            {

                int vize1 = Convert.ToInt32(txtvize1.Text);
                int vize2 = Convert.ToInt32(txtvize2.Text); /* Bu Kısımda vize1, vize2, final degişkenleri atadım convert edip toint32 degerınde*/
                int final = Convert.ToInt32(txtfinal.Text);


                int a;  /*Ve burdada a,b,c,sonuc dıye degısken atadım*/
                int b;
                int c;
                int sonuc;

                a = Convert.ToInt32(vize1 * 0.2); /* a,b,c degerlerını convert edip Yüzdelik kısımları aldım*/
                b = Convert.ToInt32(vize2 * 0.2);
                c = Convert.ToInt32(final * 0.6);
                sonuc = (a + b + c); /* Ve burdada sonuc degerıne a+b+c nin toplamını atadım*/
                txtortalama.Text = Convert.ToString(sonuc); /*Convert edip txtortalama.text'e atadım.*/


                if (sonuc >= 90 && sonuc < 100) txtharflinot.Text = ("AA");    /* Burda ise sonuc 90 ile 100 arasıysa  txtharflinota AA Diyoruz.*/
                else if (sonuc >= 80 && sonuc < 90) txtharflinot.Text = ("BA");/* Burda ise sonuc 80 ile 90 arasıysa  txtharflinota BA Diyoruz.*/
                else if (sonuc >= 70 && sonuc < 80) txtharflinot.Text = ("BB");/* Burda ise sonuc 70 ile 80 arasıysa  txtharflinota BB Diyoruz.*/
                else if (sonuc >= 60 && sonuc < 70) txtharflinot.Text = ("CB");/* Burda ise sonuc 60 ile 70 arasıysa  txtharflinota CB Diyoruz.*/
                else if (sonuc >= 50 && sonuc < 60) txtharflinot.Text = ("CC");/* Burda ise sonuc 50 ile 60 arasıysa  txtharflinota CC Diyoruz.*/
                else if (sonuc >= 45 && sonuc < 50) txtharflinot.Text = ("DC");/* Burda ise sonuc 45 ile 50 arasıysa  txtharflinota DC Diyoruz.*/
                if (sonuc >= 0 && sonuc < 45) txtharflinot.Text = ("FF");      /* Burda ise sonuc 0 ile 45 arasıysa  txtharflinota FF Diyoruz.*/
            }
            
            
        }

        private void txtortalama_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new Ogr_BilgiSistemiEntities())/* Yandaki veri tabanı yerini gösterdim ve db diye değşken atadım.  */
            {
                var query = db.Uye.Where(x => x.OgrenciNo == txtogrnoo.Text).FirstOrDefault();/* burda bı sorgulama ıslemı yapıyoruz ve verı tabanındakı ogrencı no txtogrencı no ya eşitse demişiz   */
                if (query == null)  /*query boşşsa demişiz alttaki kisimda hatayı verdırtsın mesagebox.show ile*/ 
                {
                    MessageBox.Show("Hatalı Numara Girdiniz.", "Hata");
                }
                else
                {


                    TblAkademik a = new TblAkademik();/*   Uye tablosuna a degıskenı atadım ve Textboxlardaki veriler a.OgrNo diyerek  veri tabanındaki değerlere atadım. */
                    a.OgrNo = txtogrnoo.Text;
                    a.Dersvehocalar = comboBox1.Text;
                    a.Yariyil = comboBox2.Text;
                    a.Vize1 = txtvize1.Text;
                    a.Vize2 = txtvize2.Text;
                    a.Final = txtfinal.Text;
                    a.Ortalama = txtortalama.Text;
                    a.Harfliortalama = txtharflinot.Text;
                    db.TblAkademik.Add(a);/* a degıskenını uye tablosuna ekle demişim  */
                    db.SaveChanges(); /* ve bu kısımda ıse kayettim.  */

                    MessageBox.Show("Kayıt Başarıyla Eklenmiştir.", "Bilgi"); /* Kaydetme sonucunda messagebox ile Bilgi veriyoruz Kullanıcıya */

                }
            
                
                }
            
            }
        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();/*Button3 e basıldıgı zaman Form1 formuna gonderıyor benı.*/
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Rapor form = new Rapor(); /*Button4 e basıldıgı zaman rapor formuna gonderıyor benı.*/
            form.Show();
            
        }
    }
}
