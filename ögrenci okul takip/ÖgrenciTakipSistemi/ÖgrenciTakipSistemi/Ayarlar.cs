using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ÖgrenciTakipSistemi
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        public void soru()
        {
            GizliSoru.Items.Add("Annenizin Dogum Yeri");
            GizliSoru.Items.Add("En Sevdiğiniz Öğretmeniniz");
            GizliSoru.Items.Add("En İyi Çocukluk Arkadaşınız");
            GizliSoru.Items.Add("İlk Arabanız");
            GizliSoru.Items.Add("İlk Hayvanınızın Adı ");
            GizliSoru.Items.Add("En Sevdiginiz Fulbol Tekımı");
            GizliSoru.Items.Add("İlk Görev Yaptıgınız Okul");
            GizliSoru.Items.Add("Dedenizin Meslegi");
            GizliSoru.Items.Add("Tarihte En Sevdiginiz Kişi");
            GizliSoru.Items.Add("Sevdiğiniz Müzik Türü");
            GizliSoru.Items.Add("Ögretmen Olma Tarihiniz");


            comboBox1.Items.Add("İstiyorum");

            comboBox1.Items.Add("İstemiyorum");

          

        }
        public void kaydediyom()
        {
            int a = 0, b = 0;
                int m = 0;
            if (checkBox1.Checked == true)
            {
                if (GizliSoru.Text == "" || Cevabı.Text == "")
                {
                  
                    a++;

                    if (GizliSoru.Text == "")
                    {
                        MessageBox.Show("Gizli Soru Seçmelisiniz");
                        return;
                    }
                    if (Cevabı.Text == "")
                    {
                        MessageBox.Show("Cevabı Yanıtlamalısınız");
                        return;
                    }
                }
                if (a == 0)
                {
                    b++;
                  
                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set GizliSoru='" + GizliSoru.Text + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();
                }
                if (a == 0)
                {
                    b++;

                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set GizliSoruCevabı='" + Cevabı.Text + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();
                }
                if (comboBox1.Text == "İstiyorum")
                {
                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set sifrekoruma='" + "1" + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();

                }
                if (comboBox1.Text == "İstemiyorum")
                {
                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set sifrekoruma='" + "0" + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();

                }

                if (b == 2)
                {
                    label4.Text = "Kayıt Başarılı";

             
                }
                else
                {
                    MessageBox.Show("Hatalar İcin Özür Dileriz");
                }
            }
            if (checkBox2.Checked == true)
            {
            
                if (comboBox1.Text == "İstiyorum")
                {
                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set sifrekoruma='" + "1" + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();
                    m++;
                }
                if (comboBox1.Text == "İstemiyorum")
                {
                    OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set sifrekoruma='" + "0" + "' where Sıra ='" + textBox1.Text + "'", connect);

                    güncelle.ExecuteNonQuery();
                    m++;
                }
                if (m > 0)

                {
                    label4.Text="Kayıt Başarılı";
                  
                
                }
            }
            if(a==0  && b==0 && m==0)
            {
                label4.Text = "Kayıt İcin Tik Koymalısınız";
            }
        
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {

            soru();


            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From GizliSoruVerisi", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "GizliSoruVerisi");

            dataGridView1.DataSource = dtst.Tables["GizliSoruVerisi"];

         
            adtr.Dispose();

            textBox1.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            connect.Open();
            kaydediyom();

            connect.Close();





        }

        private void Cevabı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                connect.Open();
                kaydediyom();
                connect.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ögretmen_Modu_Tasarla ac = new Ögretmen_Modu_Tasarla();
            ac.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set mod='" + "1" + "' where Sıra ='" + textBox1.Text + "'", connect);

            güncelle.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Geçilmiştir Programı Tekrar Başlatınız");

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand güncelle = new OleDbCommand("update GizliSoruVerisi set mod='" + "0" + "' where Sıra ='" + textBox1.Text + "'", connect);

            güncelle.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Geçilmiştir Programı Tekrar Başlatınız");
            
            this.Close();
        }
    }
}

