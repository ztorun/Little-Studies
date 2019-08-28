using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace ÖgrenciTakipSistemi
{
    public partial class ÖgrenciTakip : Form
    {
        public ÖgrenciTakip()
        {
            InitializeComponent();
        }
        string DosyaYolu, DosyaAdi;
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
     
      public  int c = 0;
        int arama=0;
        public class tasarım
        { 
            
        }



        public void combosec()
        {

            comboBox1.Items.Add("Bilişim Teknolojileri");
            comboBox1.Items.Add("Giyim Üretim Teknolojileri");
            comboBox1.Items.Add("Makine Teknolojileri");
            comboBox1.Items.Add("Tesisat Teknolojisi ve İklimlendirme");

            Bölümü.Items.Add("Bilişim Teknolojileri");
            Bölümü.Items.Add("Giyim Üretim Teknolojileri");
            Bölümü.Items.Add("Makine Teknolojileri");
            Bölümü.Items.Add("Tesisat Teknolojisi ve İklimlendirme");

            Ders.Items.Add("Dil Ve Anlatım");
            Ders.Items.Add("Türk Edebiyatı");
            Ders.Items.Add("Yabancı Dil");
            Ders.Items.Add("Tarih");
            Ders.Items.Add("Matematik");
            Ders.Items.Add("Geometri");
            Ders.Items.Add("Biyoloji");
            Ders.Items.Add("Kimya");
            Ders.Items.Add("Fizik");
            Ders.Items.Add("Din Kültürü");
            Ders.Items.Add("Meslek Gelişim");



            comboBox2.Items.Add("Dil Ve Anlatım");
            comboBox2.Items.Add("Türk Edebiyatı");
            comboBox2.Items.Add("Yabancı Dil");
            comboBox2.Items.Add("Tarih");
            comboBox2.Items.Add("Matematik");
            comboBox2.Items.Add("Geometri");
            comboBox2.Items.Add("Biyoloji");
            comboBox2.Items.Add("Kimya");
            comboBox2.Items.Add("Fizik");
            comboBox2.Items.Add("Din Kültürü");
            comboBox2.Items.Add("Meslek Gelişim");


        
        }
  
        
        public void listeyiyenile()
        {

            yenile();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Ögrenciler", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Ögrenciler");

            dataGridView1.DataSource = dtst.Tables["Ögrenciler"];

            adtr.Dispose();

            listBox1.Items.Clear();
            
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString());
            }


           
        }
        
        public void yenile()
        {
            OleDbCommand cmd = new OleDbCommand("select * from Ögrenciler", connect);
            OleDbDataReader oku = null;

            oku = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["Numarası"].ToString());
                kayit.SubItems.Add(oku["Adı"].ToString());
                kayit.SubItems.Add(oku["Soyadı"].ToString());
                kayit.SubItems.Add(oku["Sınıfı"].ToString());
                kayit.SubItems.Add(oku["Bölümü"].ToString());
                kayit.SubItems.Add(oku["Ders"].ToString());
                kayit.SubItems.Add(oku["Konu"].ToString());
                kayit.SubItems.Add(oku["VerilişTarihi"].ToString());
                kayit.SubItems.Add(oku["TeslimTarihi"].ToString());
                kayit.SubItems.Add(oku["Sonuc"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();
          
       


        }
        
        private void ÖgrenciTakip_Load(object sender, EventArgs e)
        {
        

            textBox8.Text = "1";
            connect.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Tasarla", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Tasarla");

            dataGridView2.DataSource = dtst.Tables["Tasarla"];


            adtr.Dispose();
            connect.Close();



            //kaydet1
            int x = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            int y = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);

            button1.Location = new Point(x, y);


            //sıfırla1
            int x1 = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
            int y1 = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);

            button7.Location = new Point(x1, y1);

            //kapat1
            int x2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[5].Value);
            int y2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[6].Value);

            button8.Location = new Point(x2, y2);
            //label27 hoşgeldiniz

            int x3 = Convert.ToInt32(dataGridView2.Rows[0].Cells[7].Value);
            int y3 = Convert.ToInt32(dataGridView2.Rows[0].Cells[8].Value);

            label27.Location = new Point(x3, y3);

            //button3 yenile

            int x4 = Convert.ToInt32(dataGridView2.Rows[0].Cells[9].Value);
            int y4 = Convert.ToInt32(dataGridView2.Rows[0].Cells[10].Value);

            button3.Location = new Point(x4, y4);
            //button 5 kapat2

            int x5 = Convert.ToInt32(dataGridView2.Rows[0].Cells[11].Value);
            int y5 = Convert.ToInt32(dataGridView2.Rows[0].Cells[12].Value);

            button5.Location = new Point(x5, y5);


            //button6 yenile2
            int x6 = Convert.ToInt32(dataGridView2.Rows[0].Cells[13].Value);
            int y6 = Convert.ToInt32(dataGridView2.Rows[0].Cells[14].Value);

            button6.Location = new Point(x6, y6);



            //button4 kaydet2
            int x7 = Convert.ToInt32(dataGridView2.Rows[0].Cells[15].Value);
            int y7 = Convert.ToInt32(dataGridView2.Rows[0].Cells[16].Value);

            button4.Location = new Point(x7, y7);


            //button9 kapat3
            int x8 = Convert.ToInt32(dataGridView2.Rows[0].Cells[17].Value);
            int y8 = Convert.ToInt32(dataGridView2.Rows[0].Cells[18].Value);

            button9.Location = new Point(x8, y8);

            //button10 resim


            int x9 = Convert.ToInt32(dataGridView2.Rows[0].Cells[19].Value);
            int y9 = Convert.ToInt32(dataGridView2.Rows[0].Cells[20].Value);

            button10.Location = new Point(x9, y9);


            if (c < 7)
            {
                c++;
            }

            pictureBox2.ImageLocation = "YardımResim/" + c.ToString() + ".jpg";
            connect.Open();
            yenile();
            listeyiyenile();
            combosec();
            connect.Close();

            timer1.Enabled = true;


           
        }

        public void Ara(ListBox name, string kelime)
        {
           
            if (arama >= name.Items.Count)
            {
                arama = 0;
            }
            if (name.Items.Count > 0)
                for (int i = arama; i < name.Items.Count; i++)
                {
                    string item = name.Items[i].ToString();
                    if (item.Length >= kelime.Length)
                        if (item.Substring(0, kelime.Length).ToUpper() == kelime.ToUpper())
                        {
                            name.SelectedIndex = i;
                            arama = i + 1;
                            return;
                        }

                    for (int l = 0; l < item.Length; l++)
                    {
                        if (l <= item.Length - kelime.Length)
                            if (item.Substring(l, kelime.Length).ToUpper() == kelime.ToUpper())
                            {
                                name.SelectedIndex = i;
                                arama = i + 1;
                                return;
                            }
                    }
                }

            for (int i = 0; i < name.Items.Count; i++)
            {
                string item = name.Items[i].ToString();
                if (item.Length >= kelime.Length)
                    if (item.Substring(0, kelime.Length).ToUpper() == kelime.ToUpper())
                    {
                        name.SelectedIndex = i;
                        arama = i + 1;
                        return;
                    }
                for (int l = 0; l < item.Length; l++)
                {
                    if (l <= item.Length - kelime.Length)
                        if (item.Substring(l, kelime.Length).ToUpper() == kelime.ToUpper())
                        {
                            name.SelectedIndex = i;
                            arama = i + 1;
                            return;
                        }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (textBox2.Text == "")
                {

                    MessageBox.Show("Adı Kısmı Boş Bırakılamaz"); a++;
                   
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Soyadı Kısmı Boş Bırakılamaz"); a++;
                }
                else if (textBox4.Text == "")
                {

                    MessageBox.Show("Sınıfı Kısmı Boş Bırakılamaz"); a++;

                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Numarası Kısmı Boş Bırakılamaz"); a++;

                }
                else if (comboBox1.Text == "")
                {

                    MessageBox.Show("Bölümü Kısmı Boş Bırakılamaz"); a++;
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Ders Kısmı Boş Bırakılamaz"); a++;
                }
                else if (textBox5.Text == "")
                {

                    MessageBox.Show("Konu Kısmı Boş Bırakılamaz"); a++;
                }
              
                if (a == 0)
                {
                   int gh=Int32.Parse(textBox6.Text);
                    if ( gh> 100)
                    {
                        MessageBox.Show("Not 100'den büyük olamaz");
                    }
                    else if (gh < 0)
                    {
                        MessageBox.Show("Not 0'dan küçük olamaz");
                    }
                    else
                    {
                        connect.Open();
                        string ekle = "Insert into Ögrenciler (Numarası,Adı,Soyadı,Sınıfı,Bölümü,Ders,Konu,VerilişTarihi,TeslimTarihi,Sonuc) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox6.Text + "')";
                        OleDbCommand cmd = new OleDbCommand(ekle, connect);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Başarı Birşekilde Kaydedilmiştir");
                        connect.Close();
                    }

                }
            }

            catch
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   connect.Open();
            try
            {

                if (textBox13.Text == "")
                {
                    MessageBox.Show("Silinecek Kişinin Numarasını Girmelisiniz");

                }
                else
                {
                    DialogResult secim;
                    secim = MessageBox.Show("Bu Kişiyi Silmek İstediginize Emin Misiniz?", "", MessageBoxButtons.YesNo);

                    if (secim == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Ögrenciler WHERE Numarası='" + textBox13.Text + "'", connect);

                        cmd.ExecuteNonQuery();

                        yenile();
                        connect.Close();

                    }
                    else
                    {
                        Refresh();
                    }
                }
              
            }
            catch
            {

                MessageBox.Show("Silenecek Öge Kalmamıştır");

                this.Close();
            }
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            
            connect.Open();
            try
            {
               
                yenile();
                connect.Close();

            }
            catch
            {
                MessageBox.Show("Hata");

            }
            connect.Close();
        }

      

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar);           

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar);           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);   
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);   
        }


        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
        }

      
      

        private void listBox1_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Ögrenciler", connect);
          
            
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (listBox1.Text == dataGridView1.Rows[i].Cells[1].Value.ToString() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        Adı.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        Soyadı.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        Sınıfı.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        Numarası.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        Bölümü.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        Ders.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        Konu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        dateTimePicker1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                        dateTimePicker1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        Sonuc.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                        textBox16.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    }

                }
                OleDbDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                  
                    pictureBox1.ImageLocation = "Resimler/" + Numarası.Text+".jpg";
                }
            }

            catch
            {
                MessageBox.Show("Hata");

            }
            connect.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();

            try
            {
                if (Adı.Text == "")
                {
                    MessageBox.Show("Adı Kısmı Boş Bırakılamaz");

                }
                else if (Soyadı.Text == "")
                {
                    MessageBox.Show("Soyadı Kısmı Boş Bırakılamaz");
                }
                else if (Sınıfı.Text == "")
                {
                    MessageBox.Show("Sınıfı Kısmı Boş Bırakılamaz");
                }
                else if (Numarası.Text== "")
                {
                    MessageBox.Show("Numarası Kısmı Boş Bırakılamaz");
                }
                else if (Bölümü.Text == "")
                {
                    MessageBox.Show("Bölümü Kısmı Boş Bırakılamaz");
                }
                else if (Ders.Text == "")
                {
                    MessageBox.Show("Ders Kısmı Boş Bırakılamaz");
                }
                else if (Konu.Text == "")
                {
                    MessageBox.Show("Konu Kısmı Boş Bırakılamaz");
                }
                else if (Sonuc.Text == "")
                {
                    MessageBox.Show("Not Kısmı Boş Bırakılamaz");
                }
                else
                {
                    int s = 0;

                    if (checkBox.Checked == true)
                    {
                        s++;

                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Adı='" + Adı.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }

                    if (checkBox2.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Soyadı='" + Soyadı.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox3.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Sınıfı='" + Sınıfı.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox4.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Numarası='" + Numarası.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox5.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Bölümü='" + Bölümü.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox6.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Ders='" + Ders.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox7.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Konu='" + Konu.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox8.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set VerilişTarihi='" + VerilişTarihi.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox9.Checked == true)
                    {
                        s++;
                        OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set TeslimTarihi='" + TeslimTarihi.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                        güncelle.ExecuteNonQuery();

                    }
                    if (checkBox10.Checked == true)
                    {
                     
                        int aö = Int32.Parse(Sonuc.Text);
                        if (aö > 100)
                        {
                            s = 60;
                            MessageBox.Show("Not 100'den büyük alamaz");
                        }
                        else
                        {
                            s++;
                            OleDbCommand güncelle = new OleDbCommand("update Ögrenciler set Sonuc='" + Sonuc.Text + "' where Numarası ='" + textBox16.Text + "'", connect);

                            güncelle.ExecuteNonQuery();
                        }

                    }
                    if (s > 0 && s<50)
                    {
                        MessageBox.Show("Başarılı Bir Şekilde Güncellendi");

                    }
                    else if (s == 0)
                    {
                        MessageBox.Show("Güncellenecek Yerlerin Başına Tik Koymalısınızı");
                    }
                  
                    listeyiyenile();
                    yenile();
                }
              
            }

            catch
            {
                MessageBox.Show("Programı Baştan Yükleyiniz Bu Program Artık İflak Olmaz");
            }
            connect.Close();

      

        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            try
            {
               
                checkBox12.Checked = false;
                checkBox.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
            }

            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu"); 
            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            try
            {
                checkBox11.Checked = false;
                checkBox.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu"); 
            }
        }

        private void Adı_KeyPress(object sender, KeyPressEventArgs e)
        {
            //strig degerler
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar); 
        }

        private void Soyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            //strig degerler
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar); 
        }

        private void Numarası_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //int deger
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
        }

        private void Bölümü_KeyPress(object sender, KeyPressEventArgs e)
        {
            //strig degerler
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar); 
        }

      

        private void Sonuc_KeyPress(object sender, KeyPressEventArgs e)
        {

            //int deger
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connect.Open();
            listeyiyenile();
            connect.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bilişim Teknolojileri")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Dil Ve Anlatım");
                comboBox2.Items.Add("Türk Edebiyatı");
                comboBox2.Items.Add("Yabancı Dil");
                comboBox2.Items.Add("Tarih");
                comboBox2.Items.Add("Matematik");
                comboBox2.Items.Add("Geometri");
                comboBox2.Items.Add("Biyoloji");
                comboBox2.Items.Add("Kimya");
                comboBox2.Items.Add("Fizik");
                comboBox2.Items.Add("Din Kültürü");
                comboBox2.Items.Add("Meslek Gelişim");
                comboBox2.Items.Add("Nesne Tabanlı Programlama");
                comboBox2.Items.Add("Grafik Animasyon");
                comboBox2.Items.Add("Mesleki Yabancıdil");
                comboBox2.Items.Add("Web Tasarım");
                comboBox2.Items.Add("E-Posta Sunucusu");
                comboBox2.Items.Add("Bilişim Teknolojileri Temelleri");
                comboBox2.Items.Add("Bilişim Teknik Resim");
                comboBox2.Items.Add("Programlama Temelleri");


            }
            else if (comboBox1.Text == "Giyim Üretim Teknolojileri")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Dil Ve Anlatım");
                comboBox2.Items.Add("Türk Edebiyatı");
                comboBox2.Items.Add("Yabancı Dil");
                comboBox2.Items.Add("Tarih");
                comboBox2.Items.Add("Matematik");
                comboBox2.Items.Add("Geometri");
                comboBox2.Items.Add("Biyoloji");
                comboBox2.Items.Add("Kimya");
                comboBox2.Items.Add("Fizik");
                comboBox2.Items.Add("Din Kültürü");
                comboBox2.Items.Add("Meslek Gelişim");
                comboBox2.Items.Add("Uygulama Teknikleri");
                comboBox2.Items.Add("Kalıp Hazırlama Teknikleri");
                comboBox2.Items.Add("Tekstil Teknolojileri");
                comboBox2.Items.Add("Giysi Teknik Çizimleri");


            }
            else if (comboBox1.Text == "Makine Teknolojileri")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Dil Ve Anlatım");
                comboBox2.Items.Add("Türk Edebiyatı");
                comboBox2.Items.Add("Yabancı Dil");
                comboBox2.Items.Add("Tarih");
                comboBox2.Items.Add("Matematik");
                comboBox2.Items.Add("Geometri");
                comboBox2.Items.Add("Biyoloji");
                comboBox2.Items.Add("Kimya");
                comboBox2.Items.Add("Fizik");
                comboBox2.Items.Add("Din Kültürü");
                comboBox2.Items.Add("Meslek Gelişim");
                comboBox2.Items.Add("Temel İmalat İşlemleri");
                comboBox2.Items.Add("Makine Bilimi ve Elemanları");
                comboBox2.Items.Add("Teknik Resim");
                comboBox2.Items.Add("Bilgisaray Destekli Tasarım");
                comboBox2.Items.Add("Malzeme Teknolojileri");


            }
            else if (comboBox1.Text == "Tesisat Teknolojisi ve İklimlendirme")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Dil Ve Anlatım");
                comboBox2.Items.Add("Türk Edebiyatı");
                comboBox2.Items.Add("Yabancı Dil");
                comboBox2.Items.Add("Tarih");
                comboBox2.Items.Add("Matematik");
                comboBox2.Items.Add("Geometri");
                comboBox2.Items.Add("Biyoloji");
                comboBox2.Items.Add("Kimya");
                comboBox2.Items.Add("Fizik");
                comboBox2.Items.Add("Din Kültürü");
                comboBox2.Items.Add("Meslek Gelişim");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
                string yol = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "//Resimler//";


                File.WriteAllBytes(yol + DosyaAdi, File.ReadAllBytes(openFileDialog1.FileName));



                MessageBox.Show("Bitti");
            }
            else
            {
               
                MessageBox.Show("Herhangi bir Kayıt Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
  
        private void button12_Click(object sender, EventArgs e)
       
        {    if (c < 7)
                {
                    c++;
                }
          
         
                pictureBox2.ImageLocation = "YardımResim/" + c.ToString() + ".jpg";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {   
            
            if (c >1)
            {
                c--;
            }

            pictureBox2.ImageLocation = "YardımResim/" + c.ToString() + ".jpg";
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Adı.Text = "";
            Soyadı.Text = "";
            Sınıfı.Text = "";
            Soyadı.Text = "";
            Numarası.Text = "";
            Sınıfı.Text = "";
            Bölümü.Text = "";
            Ders.Text = "";
            Konu.Text = "";
            VerilişTarihi.Text = "";
            TeslimTarihi.Text = "";
            Sonuc.Text = "";
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Ögrenciler", connect);
         
            try
            {
               
                
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    if (textBox7.Text.ToUpper() == dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper() || textBox7.Text.ToUpper() == dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString().ToUpper())
                    {
                        Adı.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        Soyadı.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        Sınıfı.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        Numarası.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        Bölümü.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        Ders.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        Konu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        dateTimePicker1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                        dateTimePicker1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        Sonuc.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                        textBox16.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    }

                }
                Ara(listBox1, textBox7.Text);
                OleDbDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {

                    pictureBox1.ImageLocation = "Resimler/" + Numarası.Text + ".jpg";
                }
            }

            catch
            {
                MessageBox.Show("Hata");

            }
            connect.Close();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

            Adı.Text = "";
            Soyadı.Text = "";
            Sınıfı.Text = "";
            Soyadı.Text = "";
            Numarası.Text = "";
            Sınıfı.Text = "";
            Bölümü.Text = "";
            Ders.Text = "";
            Konu.Text = "";
            VerilişTarihi.Text = "";
            TeslimTarihi.Text = "";
            Sonuc.Text = "";
            if (e.KeyData.ToString() == "Return")
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Ögrenciler", connect);
                try
                {
                  
                    for (int i = 0; i < dataGridView1.RowCount-1; i++)
                    {
                        if (textBox7.Text.ToUpper() == dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper() || textBox7.Text.ToUpper() == dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString().ToUpper())
                        {
                            Adı.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            Soyadı.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            Sınıfı.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            Numarası.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            Bölümü.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            Ders.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            Konu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                            Sonuc.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                            textBox16.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

                        }

                    }
                    Ara(listBox1, textBox7.Text);
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (rdr.HasRows)
                    {

                        pictureBox1.ImageLocation = "Resimler/" + Numarası.Text + ".jpg";
                    }
                }

                catch
                {
                    MessageBox.Show("Hata Verdim Alsana");

                }
                connect.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (timer1.Interval < 51)
            {    
                label27.Text = "Hoş Geldiniz";
                if (timer1.Interval > 1)
                {
                    timer1.Interval--;
                }
               else if (timer1.Interval > 0)
                {
                    label27.Text = "";
                }
            }
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ayarlar ac = new Ayarlar();
            ac.ShowDialog();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        

      
    }
}
