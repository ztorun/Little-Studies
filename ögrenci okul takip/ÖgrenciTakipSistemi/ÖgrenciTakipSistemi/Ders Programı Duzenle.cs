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
    public partial class Ders_Programı_Duzenle : Form
    {
        public Ders_Programı_Duzenle()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void Ders_Programı_Duzenle_Load(object sender, EventArgs e)
        {
            Com();
            connect.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From DersProgramı", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "DersProgramı");

            dataGridView1.DataSource = dtst.Tables["DersProgramı"];

            adtr.Dispose();
            connect.Close();



        }
        public void Com()


        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Dil Ve Anlatım");
            comboBox1.Items.Add("Türk Edebiyatı");
            comboBox1.Items.Add("Yabancı Dil");
            comboBox1.Items.Add("Tarih");
            comboBox1.Items.Add("Matematik");
            comboBox1.Items.Add("Geometri");
            comboBox1.Items.Add("Biyoloji");
            comboBox1.Items.Add("Kimya");
            comboBox1.Items.Add("Fizik");
            comboBox1.Items.Add("Din Kültürü");
            comboBox1.Items.Add("Meslek Gelişim");
            comboBox1.Items.Add("Nesne Tabanlı Programlama");
            comboBox1.Items.Add("Grafik Animasyon");
            comboBox1.Items.Add("Mesleki Yabancıdil");
            comboBox1.Items.Add("Web Tasarım");
            comboBox1.Items.Add("E-Posta Sunucusu");
            comboBox1.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox1.Items.Add("Bilişim Teknik Resim");
            comboBox1.Items.Add("Programlama Temelleri");



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



            comboBox3.Items.Clear();
            comboBox3.Items.Add("Dil Ve Anlatım");
            comboBox3.Items.Add("Türk Edebiyatı");
            comboBox3.Items.Add("Yabancı Dil");
            comboBox3.Items.Add("Tarih");
            comboBox3.Items.Add("Matematik");
            comboBox3.Items.Add("Geometri");
            comboBox3.Items.Add("Biyoloji");
            comboBox3.Items.Add("Kimya");
            comboBox3.Items.Add("Fizik");
            comboBox3.Items.Add("Din Kültürü");
            comboBox3.Items.Add("Meslek Gelişim");
            comboBox3.Items.Add("Nesne Tabanlı Programlama");
            comboBox3.Items.Add("Grafik Animasyon");
            comboBox3.Items.Add("Mesleki Yabancıdil");
            comboBox3.Items.Add("Web Tasarım");
            comboBox3.Items.Add("E-Posta Sunucusu");
            comboBox3.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox3.Items.Add("Bilişim Teknik Resim");
            comboBox3.Items.Add("Programlama Temelleri");



            comboBox4.Items.Clear();
            comboBox4.Items.Add("Dil Ve Anlatım");
            comboBox4.Items.Add("Türk Edebiyatı");
            comboBox4.Items.Add("Yabancı Dil");
            comboBox4.Items.Add("Tarih");
            comboBox4.Items.Add("Matematik");
            comboBox4.Items.Add("Geometri");
            comboBox4.Items.Add("Biyoloji");
            comboBox4.Items.Add("Kimya");
            comboBox4.Items.Add("Fizik");
            comboBox4.Items.Add("Din Kültürü");
            comboBox4.Items.Add("Meslek Gelişim");
            comboBox4.Items.Add("Nesne Tabanlı Programlama");
            comboBox4.Items.Add("Grafik Animasyon");
            comboBox4.Items.Add("Mesleki Yabancıdil");
            comboBox4.Items.Add("Web Tasarım");
            comboBox4.Items.Add("E-Posta Sunucusu");
            comboBox4.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox4.Items.Add("Bilişim Teknik Resim");
            comboBox4.Items.Add("Programlama Temelleri");



            comboBox5.Items.Clear();
            comboBox5.Items.Add("Dil Ve Anlatım");
            comboBox5.Items.Add("Türk Edebiyatı");
            comboBox5.Items.Add("Yabancı Dil");
            comboBox5.Items.Add("Tarih");
            comboBox5.Items.Add("Matematik");
            comboBox5.Items.Add("Geometri");
            comboBox5.Items.Add("Biyoloji");
            comboBox5.Items.Add("Kimya");
            comboBox5.Items.Add("Fizik");
            comboBox5.Items.Add("Din Kültürü");
            comboBox5.Items.Add("Meslek Gelişim");
            comboBox5.Items.Add("Nesne Tabanlı Programlama");
            comboBox5.Items.Add("Grafik Animasyon");
            comboBox5.Items.Add("Mesleki Yabancıdil");
            comboBox5.Items.Add("Web Tasarım");
            comboBox5.Items.Add("E-Posta Sunucusu");
            comboBox5.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox5.Items.Add("Bilişim Teknik Resim");
            comboBox5.Items.Add("Programlama Temelleri");





            comboBox6.Items.Clear();
            comboBox6.Items.Add("Dil Ve Anlatım");
            comboBox6.Items.Add("Türk Edebiyatı");
            comboBox6.Items.Add("Yabancı Dil");
            comboBox6.Items.Add("Tarih");
            comboBox6.Items.Add("Matematik");
            comboBox6.Items.Add("Geometri");
            comboBox6.Items.Add("Biyoloji");
            comboBox6.Items.Add("Kimya");
            comboBox6.Items.Add("Fizik");
            comboBox6.Items.Add("Din Kültürü");
            comboBox6.Items.Add("Meslek Gelişim");
            comboBox6.Items.Add("Nesne Tabanlı Programlama");
            comboBox6.Items.Add("Grafik Animasyon");
            comboBox6.Items.Add("Mesleki Yabancıdil");
            comboBox6.Items.Add("Web Tasarım");
            comboBox6.Items.Add("E-Posta Sunucusu");
            comboBox6.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox6.Items.Add("Bilişim Teknik Resim");
            comboBox6.Items.Add("Programlama Temelleri");





            comboBox7.Items.Clear();
            comboBox7.Items.Add("Dil Ve Anlatım");
            comboBox7.Items.Add("Türk Edebiyatı");
            comboBox7.Items.Add("Yabancı Dil");
            comboBox7.Items.Add("Tarih");
            comboBox7.Items.Add("Matematik");
            comboBox7.Items.Add("Geometri");
            comboBox7.Items.Add("Biyoloji");
            comboBox7.Items.Add("Kimya");
            comboBox7.Items.Add("Fizik");
            comboBox7.Items.Add("Din Kültürü");
            comboBox7.Items.Add("Meslek Gelişim");
            comboBox7.Items.Add("Nesne Tabanlı Programlama");
            comboBox7.Items.Add("Grafik Animasyon");
            comboBox7.Items.Add("Mesleki Yabancıdil");
            comboBox7.Items.Add("Web Tasarım");
            comboBox7.Items.Add("E-Posta Sunucusu");
            comboBox7.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox7.Items.Add("Bilişim Teknik Resim");
            comboBox7.Items.Add("Programlama Temelleri");



            comboBox8.Items.Clear();
            comboBox8.Items.Add("Dil Ve Anlatım");
            comboBox8.Items.Add("Türk Edebiyatı");
            comboBox8.Items.Add("Yabancı Dil");
            comboBox8.Items.Add("Tarih");
            comboBox8.Items.Add("Matematik");
            comboBox8.Items.Add("Geometri");
            comboBox8.Items.Add("Biyoloji");
            comboBox8.Items.Add("Kimya");
            comboBox8.Items.Add("Fizik");
            comboBox8.Items.Add("Din Kültürü");
            comboBox8.Items.Add("Meslek Gelişim");
            comboBox8.Items.Add("Nesne Tabanlı Programlama");
            comboBox8.Items.Add("Grafik Animasyon");
            comboBox8.Items.Add("Mesleki Yabancıdil");
            comboBox8.Items.Add("Web Tasarım");
            comboBox8.Items.Add("E-Posta Sunucusu");
            comboBox8.Items.Add("Bilişim Teknolojileri Temelleri");
            comboBox8.Items.Add("Bilişim Teknik Resim");
            comboBox8.Items.Add("Programlama Temelleri");

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






            if (listBox1.Text == "PAZARTESİ")
            {
                comboBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
        

            }

            if (listBox1.Text == "SALI")
            {
                comboBox1.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[2].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[2].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[2].Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[2].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[2].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[2].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[2].Cells[8].Value.ToString();
               

            }
            if (listBox1.Text == "CARSAMBA")
            {
                comboBox1.Text = dataGridView1.Rows[4].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[4].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[4].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[4].Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[4].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[4].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[4].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[4].Cells[8].Value.ToString();
               
            }
            if (listBox1.Text == "PERSEMBE")
            {
                comboBox1.Text = dataGridView1.Rows[6].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[6].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[6].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[6].Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[6].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[6].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[6].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[6].Cells[8].Value.ToString();
                


            }

            if (listBox1.Text == "CUMA")
            {
                comboBox1.Text = dataGridView1.Rows[8].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[8].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[8].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.Rows[8].Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.Rows[8].Cells[5].Value.ToString();
                comboBox6.Text = dataGridView1.Rows[8].Cells[6].Value.ToString();
                comboBox7.Text = dataGridView1.Rows[8].Cells[7].Value.ToString();
                comboBox8.Text = dataGridView1.Rows[8].Cells[8].Value.ToString();
               

            }
            if (listBox1.Text == "")
            { 
             comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";
                comboBox7.Text = "";
                comboBox8.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (checkBox1.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders1='" + comboBox1.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();
            

            }
            if (checkBox2.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders2='" + comboBox2.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }
            if (checkBox3.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders3='" + comboBox3.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }

            if (checkBox4.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders4='" + comboBox4.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }

            if (checkBox5.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders5='" + comboBox5.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }
            if (checkBox6.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders6='" + comboBox6.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }
            if (checkBox7.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders7='" + comboBox7.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }

            if (checkBox8.Checked == true)
            {


                OleDbCommand güncelle = new OleDbCommand("update DersProgramı set Ders8='" + comboBox8.Text + "' where gün ='" + listBox1.Text + "'", connect);

                güncelle.ExecuteNonQuery();


            }
        
           
            connect.Close();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                checkBox12.Checked = false;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
            
               
            }

            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                checkBox11.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
              
            }
            catch
            {
                MessageBox.Show("Mantıksız Bira Hata Oluştu");
            }
        }
    }
}
