using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VTIslemleri;

namespace Görsel2_Proje_SinemaOtomasyon
{
    public partial class Bilet_Satis : Form
    {
        public Bilet_Satis()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Bilet_Satis_Load(object sender, EventArgs e)
        {
            //Film
            cb_biletFilm.DisplayMember = "film_ad";
            cb_biletFilm.ValueMember = "film_id";
            cb_biletFilm.DataSource = vt.Select(@"select film_id,film_ad from tbl_Filmler");
            //  cb_biletFilm.SelectedIndex = -1;//formun loadında yüklü gelsin -1 i kaldırdık
        }

        private void cb_biletFilm_SelectedIndexChanged(object sender, EventArgs e)
        {// display ve valuemember datasource den önce tanımlanmalıymış
            cb_biletSalon.DisplayMember = "salon_ad";
            cb_biletSalon.ValueMember = "salon_id";
            // yazdıklarımız doğru olsada çalışmazmış çünkü sorgudaki joın i yapmamışız
            cb_biletSalon.DataSource = vt.Select(@"select * from tbl_seans s 
                                                   JOIN tbl_filmler f ON s.film_id=f.film_id
                                                    JOIN tbl_salon sa on s.salon_id=sa.salon_id 
                                                    where f.film_id = " + cb_biletFilm.SelectedValue);
            // cb_biletSalon.SelectedIndex = -1;// adaptor doldururken hata veriyo diye kapattım.
        }

        private void cb_biletSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_biletTarih.DisplayMember = "seanstarih";
            cb_biletTarih.ValueMember = "seans_id";
            cb_biletTarih.DataSource = vt.Select(@"select * from tbl_seans s
                                                JOIN tbl_salon sa on s.salon_id=sa.salon_id 
                                                where sa.salon_id=" + cb_biletSalon.SelectedValue + @" 
                                                and s.film_id= " + cb_biletFilm.SelectedValue);

        }

        private void cb_biletTarih_SelectedIndexChanged(object sender, EventArgs e)
        {   ////seans  saat---
            cb_biletSaat.DisplayMember = "seanssaat";
            cb_biletSaat.ValueMember = "seans_id";
            cb_biletSaat.DataSource = vt.Select(@"select * from tbl_seans s
                                                    JOIN tbl_salon sa on s.salon_id=sa.salon_id 
                                                    where s.seans_id=" + cb_biletTarih.SelectedValue + @" 
                                                and s.film_id= " + cb_biletFilm.SelectedValue + @" and
                                                    sa.salon_id=" + cb_biletSalon.SelectedValue);
        }
        int i;
        private void cb_biletSaat_SelectedIndexChanged(object sender, EventArgs e)
        {//film, seans,salon ve tarihe göre eklenen bi kayıt varsa dolu koltuk rengi değişsin
            DataTable dtbilet = vt.Select(@"select k.koltuk_id, k.koltuk_ad from tbl_bilet b 
                             JOIN tbl_filmler f ON f.film_id= b.film_id JOIN tbl_salon sl ON sl.salon_id=b.salon_id
                             JOIN tbl_seans s ON s.seans_id=b.seans_id  JOIN tbl_koltuk k ON k.koltuk_id= b.koltuk_id  
                             where  s.seanssaat='" + cb_biletSaat.Text + "' and s.seanstarih='" + cb_biletTarih.Text + @"'
                                and f.film_id=" + cb_biletFilm.SelectedValue + " and sl.salon_id =" + cb_biletSalon.SelectedValue);

            //geri gelen koltukların adlarını listboxa atıp for için adlarını kontrol etmek için kullanıcam
           lst_gerigelenkoltuk.DisplayMember = "koltuk_ad";
           lst_gerigelenkoltuk.DataSource = dtbilet;

            if (dtbilet.Rows.Count != 0)
            {//Tablonun boş olup olmadığını kontrol ediyorum.
               
                foreach (Button b in groupBox1.Controls)
                {//buton name lerine ulaşmak için foreach ile kontrollerine ulaştım
                      for (int i = 0; i < dtbilet.Rows.Count; i++)
                     {  
                      DataTable dt = vt.Select("select koltuk_id from tbl_koltuk where koltuk_ad= '" + lst_gerigelenkoltuk.Items[i].ToString() + "'");
                      if (b.Name == dtbilet.Rows[i][1].ToString())
                        {//
                            b.BackColor = Color.Brown;
                            b.Enabled = false;
                        }
                    }

               }
            }

        }



        String[] dizi = new string[70];
        int koltuksay = 0;
        public void G2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            dizi[koltuksay] = btn.Name;
            if (btn.BackColor == Color.Brown)
            {
                btn.BackColor = Color.PaleGreen;
                tx_biletKoltuk.Text = "";//tekrarı engelle
                foreach (Button b in groupBox1.Controls)
                {
                    if (b.BackColor == Color.Brown)
                    {
                        tx_biletKoltuk.Text += b.Name + ";";
                        lst_koltuk.Items.Remove(dizi[koltuksay]);//sill
                    }
                }
            }
            else
            {
                btn.BackColor = Color.Brown;
                tx_biletKoltuk.Text += btn.Name.ToString() + ";";
                lst_koltuk.Items.Add(dizi[koltuksay]);
            }
            koltuksay++;
        }
        
        private void bt_biletAl_Click(object sender, EventArgs e)
        {int ucret = 0;
                if (tx_biletAd.Text == "" || tx_biletSoyad.Text == "" || tx_biletKoltuk.Text == "")
                { MessageBox.Show("ad, soyad ve koltuk seçimi yapınız."); return;}

             //--------------seçili radio butona göre fiyat hesaplatma
                if (rb_ogrenci.Checked == true)
                    ucret = (lst_koltuk.Items.Count)*5;
                else if (rb_tam.Checked == true)
                    ucret = (lst_koltuk.Items.Count)*10;


             //--------------seans bilgilerine göre seans_idsini bulmak:
               DataTable dtseans = vt.Select(@"select s.seans_id, s.seanssaat, s.seanstarih, f.film_id, sl.salon_id from tbl_seans s
                                JOIN tbl_filmler f ON f.film_id=s.film_id JOIN tbl_salon sl ON sl.salon_id= s.salon_id where 
                s.seanssaat='" +cb_biletSaat.Text+"' and s.seanstarih='" + cb_biletTarih.Text + "' and f.film_id=" + cb_biletFilm.SelectedValue + @" 
                             and sl.salon_id =" + cb_biletSalon.SelectedValue);
                int seansTut = Convert.ToInt32(dtseans.Rows[0][0].ToString());

             //--------------tüm bilgilere göre koltukları kaydetmek :
             
            for (int i = 0; i < lst_koltuk.Items.Count; i++)
            {//koltuk adları listbox da ve bizim koltuk_id ye ihtiyacımız var 

                DataTable dt = vt.Select("select koltuk_id from tbl_koltuk where koltuk_ad= '" + lst_koltuk.Items[i].ToString() + "'");
                cmb_koltuk_id.Items.Add(dt.Rows[0][0].ToString());

                    int sayi = vt.Insert(@"insert into tbl_bilet (musteriAd,musteriSoyad,ucret,film_id,salon_id,seans_id,koltuk_id )
                                            values('" + tx_biletAd.Text + "','" + tx_biletSoyad.Text + "',"+ucret+
                                                      "," + cb_biletFilm.SelectedValue + "," + cb_biletSalon.SelectedValue +
                                                      "," + seansTut + "," + cmb_koltuk_id.Items[i].ToString() + ")");
                    if (sayi < 1)
                    { MessageBox.Show("Bir Hata nedeniyle bilet alınamadı."); return;}
             }
        }
            /*int sayi = vt.Insert(@"insert into tbl_koltuk(koltuk_ad)values('"+btn.Name.ToString()+"')");koltuk adları listbox da ve bizim koltuk_id ye ihtiyacımız var 
             int say=  vt.Insert("insert into tbl_salon (salon_ad) values ('"+lst_koltuk.Items[i].ToString()+"')");
            /*combobox a dönecek tek değerin id sini atamak
             * comboBox1.DisplayMember = "koltuk_id";
            comboBox1.DataSource = vt.Select("select koltuk_id from tbl_koltuk where koltuk_ad= '" + lst_koltuk.Items[0].ToString() + "'");*/
            /*  DataTable dt = vt.Select("select koltuk_id from tbl_koltuk where koltuk_ad= '"+ lst_koltuk.Items[i].ToString() + "'");
              comboBox1.Items.Add(dt.Rows[0][0].ToString());
            lst_koltuk.Items[0].ToString()//değere ulaşılıyo
            cb_biletFilm.SelectedValue.ToString()//id ye ulaşmak
         
             * MessageBox.Show("value: " + cb_biletSaat.ValueMember + "- display: " + cb_biletSaat.DisplayMember);
             //ValueMember id tutmuyo sadece id sütununu belirtiyo */
    }
}
