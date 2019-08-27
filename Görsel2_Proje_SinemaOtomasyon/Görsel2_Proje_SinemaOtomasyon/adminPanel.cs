using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using VTIslemleri;


namespace Görsel2_Proje_SinemaOtomasyon
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void adminPanel_Load(object sender, EventArgs e)
        {
            //sinema ekle
            DataTable st = vt.Select(@"select a.sinema_id, a.sinema_ad,a.il,a.ilce,a.mah,a.sokak,a.no,a.telefon from tbl_sinema a");
            dgv_sinema.DataSource = st;
            dgv_sinema.Columns[0].Visible = false;
            //combooo
            cb_sinemaSecim.DataSource = vt.Select(@"select sinema_id,sinema_ad from tbl_sinema order by sinema_id asc");
            cb_sinemaSecim.DisplayMember = "sinema_ad";
            cb_sinemaSecim.ValueMember = "sinema_id";
            cb_sinemaSecim.SelectedIndex = -1;
            // ----
            cb_seansFilm.DataSource = vt.Select(@"select film_id,film_ad from tbl_Filmler order by film_id asc");
            cb_seansFilm.DisplayMember = "film_ad";
            cb_seansFilm.ValueMember = "film_id";
            cb_seansFilm.SelectedIndex = -1;
            //--------
            cb_aktorFilm.DataSource = vt.Select(@"select film_id,film_ad from tbl_Filmler order by film_id asc");
            cb_aktorFilm.DisplayMember = "film_ad";
            cb_aktorFilm.ValueMember = "film_id";
            cb_aktorFilm.SelectedIndex = -1;
            //------
            cb_yonetFilm.DataSource = vt.Select(@"select film_id,film_ad from tbl_Filmler order by film_id asc");
            cb_yonetFilm.DisplayMember = "film_ad";
            cb_yonetFilm.ValueMember = "film_id";
            cb_yonetFilm.SelectedIndex = -1;
            //------
            cb_seansSalon.DataSource = vt.Select(@"select salon_id,salon_ad from tbl_Salon order by salon_id asc");
            cb_seansSalon.DisplayMember = "salon_ad";
            cb_seansSalon.ValueMember = "salon_id";
            cb_seansSalon.SelectedIndex = -1;
            //--------
            cb_filmTur.DataSource = vt.Select(@"select k.kategori_id,k.kategori_ad from tbl_kategori k order by kategori_id asc ");
            cb_filmTur.DisplayMember = "kategori_ad";
            cb_filmTur.ValueMember = "kategori_id";
            cb_filmTur.SelectedIndex = -1;
            //filmler film ekle
            DataTable ft = vt.Select(@"select f.film_id,f.film_ad,f.vizyonTarihi,f.ulke,f.dakika,f.yapim,f.resim,k.kategori_ad from tbl_filmler f join tbl_kategori k on k.kategori_id=f.kategori_id");
            dgv_film.DataSource = ft;
            dgv_film.Columns[0].Visible = false;
            // Seans Ekle
            DataTable kt = vt.Select(@"select s.seans_id,s.seanstarih,s.seanssaat,e.sinema_ad,f.film_ad,p.salon_ad from tbl_seans s join tbl_sinema e on e.sinema_id=s.sinema_id
join tbl_filmler f on  f.film_id=s.film_id
join tbl_salon p on p.salon_id=s.salon_id");
            dgv_seans.DataSource = kt;
            dgv_seans.Columns[0].Visible = false;
           
            // Aktor Ekle
            DataTable at = vt.Select(@"select a.aktor_id,a.aktor_ad,a.aktor_soyad,a.adogumTar,a.aktorUlke,f.film_ad from tbl_aktor a join tbl_filmler f on a.film_id=f.film_id");
            dgv_aktor.DataSource = at;
            dgv_aktor.Columns[0].Visible = false;
            // yonetmen ekle
            DataTable yt = vt.Select(@"select y.yonetmen_id,y.yonetmen_ad,y.yonetmen_soyad,y.ydogumtar,y.ulke,f.film_ad from tbl_yonetmen y join tbl_filmler f on y.film_id=f.film_id");
            dgv_yonetmen.DataSource = yt;
            dgv_yonetmen.Columns[0].Visible = false;
        }

        private void btn_sinemaEkle_Click(object sender, EventArgs e)
        {
            ep_hata.Clear();
            int hata = 0;
            if (tx_sinemaAd.Text=="")
            {
                ep_hata.SetError(tx_sinemaAd, "Sinema Adını Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_il.Text=="")
            {
                ep_hata.SetError(tx_il, "Bulunduğu il'i Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_ilce.Text=="")
            {
                ep_hata.SetError(tx_ilce, "Bulunduğu ilçe'yi Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_mah.Text=="")
            {
                ep_hata.SetError(tx_mah, "Bulunduğu Mahalle'yi Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_sok.Text=="")
            {
                ep_hata.SetError(tx_sok, "Bulunduğu Sokak Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_no.Text=="")
            {
                ep_hata.SetError(tx_no, "Bulunduğu No Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_tel.Text=="")
            {
                ep_hata.SetError(tx_tel, "Telefon Numarasını Giriniz..");
                hata = 1;
                //return;
            }
            if (hata == 1)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!!");
                return;
            }
            else
            {
                int sayi = vt.Insert(@"INSERT INTO tbl_Sinema(sinema_ad,il,ilce,mah,sokak,no,telefon) 
VALUES('" + tx_sinemaAd.Text + "','" + tx_il.Text + "','" + tx_ilce.Text + "','" + tx_mah.Text + "','" + tx_sok.Text + "'," + tx_no.Text + ",'" + tx_tel.Text + "')");
                if (sayi > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt Eklendi..");
                }
            }
            tx_sinemaAd.Text = "";
            tx_il.Text = "";
            tx_ilce.Text = "";
            tx_mah.Text = "";
            tx_sok.Text = "";
            tx_no.Text = "";
            tx_tel.Text = "";
        }

        private void btn_filmEkle_Click(object sender, EventArgs e)
        {
          /*  ep_hata.Clear();
            int hata = 0;
            if (tx_filmAd.Text == "")
            {
                ep_hata.SetError(tx_filmAd, "Film Adını Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_ulke.Text=="")
            {
                ep_hata.SetError(tx_ulke, "Ülke Giriniz..");
                hata = 1;
                //return;
            }
                if (tx_sure.Text=="")
            {
                ep_hata.SetError(tx_sure, "Film Dakikasını Giriniz..");
                hata = 1;
                //return;
            }
            if (tx_yapimYili.Text=="")
            {
                ep_hata.SetError(tx_yapimYili, "Film yapım yılını Giriniz..");
                hata = 1;
                //return;
            }
            if (cb_filmTur.SelectedIndex==-1)
            {
                ep_hata.SetError(cb_filmTur, "Film türü Seçiniz..");
                hata = 1;
                //return;
            }
            else
            {*/
                int sayi = vt.Insert(@"INSERT INTO tbl_filmler(film_ad,vizyonTarihi,ulke,dakika,yapim,resim,kategori_id)
 VALUES('" + tx_filmAd.Text + "','" + dtp_vizyonTarih.Text + "','" + tx_ulke.Text + "','" + tx_sure.Text + "'," + tx_yapimYili.Text + ",'" + resimuzantiliadi + "'," + cb_filmTur.SelectedValue.ToString() + ")");
                if (sayi > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt Eklendi..");
                }
           // }
            tx_filmAd.Text = "";
            tx_ulke.Text = "";
            tx_sure.Text = "";
            tx_yapimYili.Text = "";
            cb_filmTur.SelectedIndex = -1;

            
        }
        string dosyaYolu;
        string resimuzantiliadi;
        
        private void btn_filmResimYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resimuzantiliadi = openFileDialog1.SafeFileName;
            dosyaYolu = Path.GetFileName(openFileDialog1.FileName);

            if (File.Exists("" + dosyaYolu)) // "" tırnak yapılmasının nedeni kopyalanacak dosyayı program exe dosyasının bulunduğu konumda dosyanın var olup olmadığını kontrol etmek için. 
            {
                MessageBox.Show("Dosya zaten mevcut");
            }
            else
            {
                File.Copy(openFileDialog1.FileName, "" + dosyaYolu); // "" tırnak yapılmasının nedeni kopyalanacak dosyayı program exe dosyasının bulunduğu konuma kopyalamak için.  

                MessageBox.Show("Dosya kopyalandı");

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pb_resim.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void btn_seansEkle_Click(object sender, EventArgs e)
        {
           /*  ep_hata.Clear();
            int hata = 0;
            if (cb_sinemaSecim.SelectedIndex==-1)
            {
                ep_hata.SetError(cb_sinemaSecim, "Sinema Seçiniz...");
                hata = 1;
                //return;
            }
            if (cb_seansFilm.SelectedIndex == -1)
            {
                ep_hata.SetError(cb_seansFilm, "Film Seçinz...");
                hata = 1;
                //return;
            }
            if (cb_seansSalon.SelectedIndex == -1)
            {
                ep_hata.SetError(cb_seansSalon, "Salon Seçiniz..");
                hata = 1;
                //return;
            }
            if (tx_seansSaat.Text=="")
            {
                ep_hata.SetError(tx_seansSaat, "Seans saati Giriniz..");
                hata = 1;
                //return;
            }

            else 
            {*/
             int sayi = vt.Insert(@"insert into tbl_seans (seanstarih,seanssaat,sinema_id,film_id,salon_id)values('" + dtp_seansTarih.Text + "','" + tx_seansSaat.Text + "',"+cb_sinemaSecim.SelectedValue.ToString()+","+cb_seansFilm.SelectedValue.ToString()+","+cb_seansSalon.SelectedValue.ToString()+")");

            if (sayi > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Eklendi..");
            }   
          //  }
            cb_sinemaSecim.SelectedIndex = -1;
            cb_seansFilm.SelectedIndex = - 1;
            cb_seansSalon.SelectedIndex = -1;
            tx_seansSaat.Text = "";
            
        }
        private void btn_aktorEkle_Click(object sender, EventArgs e)
        {
          /*  ep_hata.Clear();
            int hata = 0;
            if (tx_aktorAd.Text=="")
            {
                ep_hata.SetError(tx_aktorAd, "Aktor Adını Giriniz..");
                hata = 1;
                //return;
            }
                if (tx_aktorSoyad.Text=="")
            {
                ep_hata.SetError(tx_aktorSoyad, "Aktor Soyadını Giriniz..");
                hata = 1;
                //return;
            }
                    if (tx_aktorUlke.Text=="")
            {
                ep_hata.SetError(tx_aktorUlke, "Aktor Ülkesini Giriniz..");
                hata = 1;
                //return;
            }
                        if (cb_aktorFilm.SelectedIndex==-1)
            {
                ep_hata.SetError(cb_aktorFilm, "Aktor Filmini Giriniz..");
                hata = 1;
                //return;
            }

            else
            {*/
                int sayi = vt.Insert(@"insert into tbl_aktor(aktor_ad,aktor_soyad,adogumTar,aktorUlke,film_id)values('" + tx_aktorAd.Text + "','" + tx_aktorSoyad.Text + "','" + dtp_aktortar.Text + "','" + tx_aktorUlke.Text + "'," + cb_aktorFilm.SelectedValue.ToString() + ")");

                if (sayi > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt Eklendi..");
                }
          //  }
                        tx_aktorAd.Text = "";
                        tx_aktorSoyad.Text = "";
                        tx_aktorUlke.Text = "";
                        cb_aktorFilm.SelectedIndex = -1;
            
        }

        private void btn_aktorSil_Click(object sender, EventArgs e)
        {
            if (dgv_aktor.SelectedRows.Count == 0)
                return;
            int aktor_id = (int)dgv_aktor.SelectedRows[0].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int kayitSay = vt.UpdateDelete(@"DELETE FROM tbl_Aktor WHERE aktor_id =" + aktor_id);
                tx_aktorAd.Text = "";
                tx_aktorSoyad.Text = "";
                tx_aktorUlke.Text = "";
                cb_aktorFilm.SelectedIndex = -1;
                if (kayitSay > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt silindi.");
                }
                else
                    MessageBox.Show("Hata oluştuğundan kayıt sislinemedi.");

            }
        }

        private void btn_yonetmenEkle_Click(object sender, EventArgs e)
        {
           /* ep_hata.Clear();
            int hata = 0;
            if (tx_yonetmenAd.Text=="")
            {
                ep_hata.SetError(tx_yonetmenAd, "Yonetmen Adınızı Giriniz..");
                hata = 1;
                //return;
            }
                 if (tx_yonetmenSoyad.Text=="")
            {
                ep_hata.SetError(tx_yonetmenSoyad, "Yonetmen Soyadını Giriniz..");
                hata = 1;
                //return;
            }
                      if (tx_yonetmenUlke.Text=="")
            {
                ep_hata.SetError(tx_yonetmenUlke, "Yonetmen Ulkesini Giriniz..");
                hata = 1;
                //return;
            }
                           if (cb_yonetFilm.SelectedIndex==-1)
            {
                ep_hata.SetError(tx_yapimYili, "Film Seciniz..");
                hata = 1;
                //return;
            }

            else
            {*/
                int sayi = vt.Insert(@"insert into tbl_yonetmen(yonetmen_ad,yonetmen_soyad,ydogumtar,ulke,film_id)values('" + tx_yonetmenAd.Text + "','" + tx_yonetmenSoyad.Text + "','" + dtp_yonetmenTar.Text + "','" + tx_yonetmenUlke.Text + "'," + cb_yonetFilm.SelectedValue.ToString() + ")");

                if (sayi > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt Eklendi..");
                }
           // }
                           tx_yonetmenAd.Text = "";
                           tx_yonetmenSoyad.Text = "";
                           tx_yonetmenUlke.Text = "";
                           cb_yonetFilm.SelectedIndex = -1;
            
        }

        private void btn_yonetmenSil_Click(object sender, EventArgs e)
        {
            if (dgv_yonetmen.SelectedRows.Count == 0)
                return;
            int yonetmen_id = (int)dgv_yonetmen.SelectedRows[0].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int kayitSay = vt.UpdateDelete(@"DELETE FROM tbl_yonetmen WHERE yonetmen_id =" + yonetmen_id);
                tx_yonetmenAd.Text = "";
                tx_yonetmenSoyad.Text = "";
                tx_yonetmenUlke.Text = "";
                cb_yonetFilm.SelectedIndex = -1;
                if (kayitSay > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt silindi.");
                }
                else
                    MessageBox.Show("Hata oluştuğundan kayıt sislinemedi.");

            }
        }

        private void btn_seansSil_Click(object sender, EventArgs e)
        {
            if (dgv_seans.SelectedRows.Count == 0)
                return;
            int seans_id = (int)dgv_seans.SelectedRows[0].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int kayitSay = vt.UpdateDelete(@"DELETE FROM tbl_seans WHERE seans_id =" + seans_id);
                cb_sinemaSecim.SelectedIndex = -1;
                cb_seansFilm.SelectedIndex = -1;
                cb_seansSalon.SelectedIndex = -1;
                tx_seansSaat.Text = "";
                if (kayitSay > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt silindi.");
                }
                else
                    MessageBox.Show("Hata oluştuğundan kayıt sislinemedi.");

            }
        }

        private void btn_filmSil_Click(object sender, EventArgs e)
        {
            if (dgv_film.SelectedRows.Count == 0)
                return;
            int film_id = (int)dgv_film.SelectedRows[0].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int kayitSay = vt.UpdateDelete(@"DELETE FROM tbl_filmler WHERE film_id =" + film_id);
                tx_filmAd.Text = "";
                tx_ulke.Text = "";
                tx_sure.Text = "";
                tx_yapimYili.Text = "";
                cb_filmTur.SelectedIndex = -1;
                if (kayitSay > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt silindi.");
                }
                else
                    MessageBox.Show("Hata oluştuğundan kayıt sislinemedi.");

            }
           
        }

        private void btn_sinemaSil_Click(object sender, EventArgs e)
        {
            if (dgv_sinema.SelectedRows.Count == 0)
                return;
            int sinema_id = (int)dgv_sinema.SelectedRows[0].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int kayitSay = vt.UpdateDelete(@"DELETE FROM tbl_sinema WHERE sinema_id =" + sinema_id);
                tx_sinemaAd.Text = "";
                tx_il.Text = "";
                tx_ilce.Text = "";
                tx_mah.Text = "";
                tx_sok.Text = "";
                tx_no.Text = "";
                tx_tel.Text = "";
                if (kayitSay > 0)
                {
                    adminPanel_Load(null, null);
                    MessageBox.Show("Kayıt silindi.");
                }
                else
                    MessageBox.Show("Hata oluştuğundan kayıt sislinemedi.");

            }
        }

        private void btn_sinemaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_sinema.SelectedRows.Count == 0)
                return;
            int sinema_id = (int)dgv_sinema.SelectedRows[0].Cells[0].Value;
            int kayitSay = vt.UpdateDelete(@"UPDATE tbl_sinema 
            SET sinema_ad='"+tx_sinemaAd.Text+"', il='"+tx_il.Text+"',ilce='"+tx_ilce.Text+"',mah='"+tx_mah.Text+"',sokak='"+tx_sok.Text+"',no='"+tx_no.Text+"',telefon='"+tx_tel.Text+"' WHERE sinema_id="+sinema_id);
            tx_sinemaAd.Text = "";
            tx_il.Text = "";
            tx_ilce.Text = "";
            tx_mah.Text = "";
            tx_sok.Text = "";
            tx_no.Text = "";
            tx_tel.Text = "";
            if (kayitSay > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi.");
            }
        }

        private void btn_filmGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_film.SelectedRows.Count == 0)
                return;
            int film_id = (int)dgv_film.SelectedRows[0].Cells[0].Value;
            int kayitSay = vt.UpdateDelete(@"UPDATE tbl_filmler 
            SET film_ad='" + tx_filmAd.Text + "', vizyonTarihi='" + dtp_vizyonTarih.Text + "',ulke='" + tx_ulke.Text + "',dakika='" + tx_sure.Text + "',yapim='" + tx_yapimYili.Text + "',resim='" + resimuzantiliadi + "',kategori_id='"+cb_filmTur.SelectedValue.ToString()+"' WHERE film_id=" + film_id);
            tx_filmAd.Text = "";
            tx_ulke.Text = "";
            tx_sure.Text = "";
            tx_yapimYili.Text = "";
            cb_filmTur.SelectedIndex = -1;
            if (kayitSay > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi.");
            }
        }

        private void btn_seansGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_seans.SelectedRows.Count == 0)
                return;
            int seans_id = (int)dgv_seans.SelectedRows[0].Cells[0].Value;
            int kayitSay = vt.UpdateDelete(@"UPDATE tbl_seans 
            SET seanstarih='"+dtp_seansTarih.Text+"',seanssaat='"+tx_seansSaat.Text+"',sinema_id="+cb_sinemaSecim.SelectedValue.ToString()+",film_id="+cb_seansFilm.SelectedValue.ToString()+",salon_id="+cb_seansSalon.SelectedValue.ToString()+" WHERE seans_id=" + seans_id);
            cb_sinemaSecim.SelectedIndex = -1;
            cb_seansFilm.SelectedIndex = -1;
            cb_seansSalon.SelectedIndex = -1;
            tx_seansSaat.Text = "";
            if (kayitSay > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi.");
            }
        }

        private void btn_aktorGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_aktor.SelectedRows.Count == 0)
                return;
            int aktor_id = (int)dgv_aktor.SelectedRows[0].Cells[0].Value;
            int kayitSay = vt.UpdateDelete(@"UPDATE tbl_aktor 
            SET aktor_ad='"+tx_aktorAd.Text+"',aktor_soyad='"+tx_aktorSoyad.Text+"',adogumTar='"+dtp_aktortar.Text+"',aktorUlke='"+tx_aktorUlke.Text+"',film_id="+cb_aktorFilm.SelectedValue.ToString()+" WHERE aktor_id=" + aktor_id);
            tx_aktorAd.Text = "";
            tx_aktorSoyad.Text = "";
            tx_aktorUlke.Text = "";
            cb_aktorFilm.SelectedIndex = -1;
            if (kayitSay > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi.");
            }
        }

        private void btn_yonetmenGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_yonetmen.SelectedRows.Count == 0)
                return;
            int yonetmen_id = (int)dgv_yonetmen.SelectedRows[0].Cells[0].Value;
            int kayitSay = vt.UpdateDelete(@"UPDATE tbl_yonetmen 
            SET yonetmen_ad='"+tx_yonetmenAd.Text+"',yonetmen_soyad='"+tx_yonetmenSoyad.Text+"',ydogumtar='"+dtp_yonetmenTar.Text+"',ulke='"+tx_yonetmenUlke.Text+"',film_id="+cb_yonetFilm.SelectedValue.ToString()+" WHERE yonetmen_id=" + yonetmen_id);
            tx_yonetmenAd.Text = "";
            tx_yonetmenSoyad.Text = "";
            tx_yonetmenUlke.Text = "";
            cb_yonetFilm.SelectedIndex = -1;
            if (kayitSay > 0)
            {
                adminPanel_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi.");
            }
        }

        private void dgv_sinema_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_sinema.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
              
                tx_sinemaAd.Text = dgv_sinema.SelectedRows[0].Cells[1].Value.ToString();
                tx_il.Text = dgv_sinema.SelectedRows[0].Cells[2].Value.ToString();
                tx_ilce.Text = dgv_sinema.SelectedRows[0].Cells[3].Value.ToString();
                tx_mah.Text = dgv_sinema.SelectedRows[0].Cells[4].Value.ToString();
                tx_sok.Text = dgv_sinema.SelectedRows[0].Cells[5].Value.ToString();
                tx_no.Text = dgv_sinema.SelectedRows[0].Cells[6].Value.ToString();
                tx_tel.Text = dgv_sinema.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btn_sinemaTemizle_Click(object sender, EventArgs e)
        {
            tx_sinemaAd.Text = "";
            tx_il.Text = "";
            tx_ilce.Text = "";
            tx_mah.Text = "";
            tx_sok.Text = "";
            tx_no.Text = "";
            tx_tel.Text = "";
            ep_hata.Clear();
        }

        private void tx_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void tx_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btn_filmTemizle_Click(object sender, EventArgs e)
        {
            tx_filmAd.Text = "";
            tx_ulke.Text = "";
            tx_sure.Text = "";
            tx_yapimYili.Text = "";
            cb_filmTur.SelectedIndex = -1;
            ep_hata.Clear();
        }

        private void dgv_film_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_film.SelectedRows.Count == 0)
            {
                return;

            }
            else
            {

               
                tx_filmAd.Text = dgv_film.SelectedRows[0].Cells[1].Value.ToString();
                dtp_vizyonTarih.Text = dgv_film.SelectedRows[0].Cells[2].Value.ToString();
                tx_ulke.Text = dgv_film.SelectedRows[0].Cells[3].Value.ToString();
                tx_sure.Text = dgv_film.SelectedRows[0].Cells[4].Value.ToString();
                tx_yapimYili.Text = dgv_film.SelectedRows[0].Cells[5].Value.ToString();
               cb_filmTur.Text = dgv_film.SelectedRows[0].Cells[7].Value.ToString();
               
            }
        }

        private void btn_seansTemizle_Click(object sender, EventArgs e)
        {
            cb_sinemaSecim.SelectedIndex = -1;
            cb_seansFilm.SelectedIndex = -1;
            cb_seansSalon.SelectedIndex = -1;
            tx_seansSaat.Text = "";
            ep_hata.Clear();
        }

        private void dgv_seans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_seans.SelectedRows.Count == 0)
            {
                return;

            }
            else
            {
                tx_seansSaat.Text = dgv_seans.SelectedRows[0].Cells[2].Value.ToString();
                cb_sinemaSecim.Text = dgv_seans.SelectedRows[0].Cells[3].Value.ToString();
                cb_seansFilm.Text = dgv_seans.SelectedRows[0].Cells[4].Value.ToString();
                cb_seansSalon.Text = dgv_seans.SelectedRows[0].Cells[5].Value.ToString();
                
            }
        }

        private void tx_seansSaat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void dgv_aktor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_aktor.SelectedRows.Count == 0)
            {
                return;

            }
            else
            {
                tx_aktorAd.Text = dgv_aktor.SelectedRows[0].Cells[1].Value.ToString();
                tx_aktorSoyad.Text = dgv_aktor.SelectedRows[0].Cells[2].Value.ToString();
                tx_aktorUlke.Text = dgv_aktor.SelectedRows[0].Cells[4].Value.ToString();
                cb_aktorFilm.Text = dgv_aktor.SelectedRows[0].Cells[5].Value.ToString();


            }
        }

        private void btn_aktorTemizle_Click(object sender, EventArgs e)
        {
            tx_aktorAd.Text = "";
            tx_aktorSoyad.Text = "";
            tx_aktorUlke.Text = "";
            cb_aktorFilm.SelectedIndex = -1;
            ep_hata.Clear();
        }

        private void dgv_yonetmen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yonetmen.SelectedRows.Count == 0)
            {
                return;

            }
            else
            {
                tx_yonetmenAd.Text = dgv_yonetmen.SelectedRows[0].Cells[1].Value.ToString();
                tx_yonetmenSoyad.Text = dgv_yonetmen.SelectedRows[0].Cells[2].Value.ToString();
                tx_yonetmenUlke.Text = dgv_yonetmen.SelectedRows[0].Cells[4].Value.ToString();
                cb_yonetFilm.Text = dgv_yonetmen.SelectedRows[0].Cells[5].Value.ToString();


            }
        }

        private void btn_yonetmenTemizle_Click(object sender, EventArgs e)
        {
            tx_yonetmenAd.Text = "";
            tx_yonetmenSoyad.Text = "";
            tx_yonetmenUlke.Text = "";
            cb_yonetFilm.SelectedIndex = -1;
            ep_hata.Clear();
        }




    }
}