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
    public partial class Okul_Takip : Form
    {
        public Okul_Takip()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        public void yenile()
        {
            OleDbCommand cmd = new OleDbCommand("select * from DersProgramı", connect);
            OleDbDataReader oku = null;
           
            oku = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["gün"].ToString());
                kayit.SubItems.Add(oku["Ders1"].ToString());
                kayit.SubItems.Add(oku["Ders2"].ToString());
                kayit.SubItems.Add(oku["Ders3"].ToString());
                kayit.SubItems.Add(oku["Ders4"].ToString());
                kayit.SubItems.Add(oku["Ders5"].ToString());
                kayit.SubItems.Add(oku["Ders6"].ToString());
                kayit.SubItems.Add(oku["Ders7"].ToString());
                kayit.SubItems.Add(oku["Ders8"].ToString());
                
                listView1.Items.Add(kayit);
            }
           
            oku.Close();


           



        }
        public void yenile2()
        {
            
            OleDbCommand cmd2 = new OleDbCommand("select * from ÖdevTablo", connect);
            OleDbDataReader oku2 = null;
            oku2 = cmd2.ExecuteReader();
            listView2.Items.Clear();
            while (oku2.Read())
            {
                ListViewItem kayit2 = new ListViewItem(oku2["Ders"].ToString());
               
                kayit2.SubItems.Add(oku2["verilis"].ToString());
                kayit2.SubItems.Add(oku2["Ödev"].ToString());

                listView2.Items.Add(kayit2);
            }

            oku2.Close();
      


        }
        public void yenile3()
        {
            OleDbCommand cmd3 = new OleDbCommand("select * from sınav", connect);
            OleDbDataReader oku3 = null;
            oku3 = cmd3.ExecuteReader();
            listView3.Items.Clear();
            while (oku3.Read())
            {
                ListViewItem kayit3 = new ListViewItem(oku3["Ders"].ToString());

                kayit3.SubItems.Add(oku3["SınavTarihi"].ToString());
                kayit3.SubItems.Add(oku3["NerdenCıkacak"].ToString());

                listView3.Items.Add(kayit3);
            }

            oku3.Close();
        }

        public void listeyiyenile()
        {


            yenile();

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Ögretmenler", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Ögretmenler");

            dataGridView1.DataSource = dtst.Tables["Ögretmenler"];

            adtr.Dispose();

            listBox1.Items.Clear();

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                listBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString() + " " + dataGridView1.Rows[i].Cells[1].Value.ToString());
            }



        }
        private void Okul_Takip_Load(object sender, EventArgs e)
        {
            connect.Open();


            yenile();
            yenile2();
            yenile3();
            listeyiyenile();


            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Ögretmenler", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Ögretmenler");

            dataGridView1.DataSource = dtst.Tables["Ögretmenler"];


            adtr.Dispose();



      

           
            connect.Close();



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
   


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ders_Programı_Duzenle ay = new Ders_Programı_Duzenle();
            ay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ödev_Ekle ödev = new Ödev_Ekle();
            ödev.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sınav_Ekle sın = new Sınav_Ekle();
            sın.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM ÖdevTablo WHERE Ders='" +comboBox1.Text + "'", connect);
            MessageBox.Show("Başarılı");
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            connect.Open();
            try
            {
               
                
                OleDbCommand cmd = new OleDbCommand("DELETE FROM sınav WHERE Ders='" + comboBox2.Text + "'", connect);
                MessageBox.Show("Başarılı");
                cmd.ExecuteNonQuery();
               
            }


            catch
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı");
            }
            connect.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ögretmen_Ekle oek = new Ögretmen_Ekle();
            oek.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Ögretmenler", connect);
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (listBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString() + " " + dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {

                        textBox3.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        textBox4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        textBox5.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                       

                    }

                }
                OleDbDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {

                    pictureBox1.ImageLocation = "ögretmenResim/" + listBox1.Text + ".jpg";
                }
            }

            catch
            {
                MessageBox.Show("Hata");

            }
            connect.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connect.Open();
         
            yenile2();

            connect.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connect.Open();
            yenile();
            connect.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ayarlar ac = new Ayarlar();
            ac.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            connect.Open();
            yenile3();
            connect.Close();
        }

       


            
       
           
        
        


     
    }
}
