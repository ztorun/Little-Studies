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
    public partial class Ögretmen_Ekle : Form
    {
        public Ögretmen_Ekle()
        {
            InitializeComponent();
        }
        string DosyaYolu, DosyaAdi;
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string ekle = "Insert into Ögretmenler (Adı,Soyadı,Dalı) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')";
            OleDbCommand cmd = new OleDbCommand(ekle, connect);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Öğretmen  Başarı Birşekilde Eklenmiştir");
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in openFileDialog1.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
                string yol = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "//ögretmenResim//";


                File.WriteAllBytes(yol + DosyaAdi, File.ReadAllBytes(openFileDialog1.FileName));



                MessageBox.Show("Bitti");
            }
            else
            {

                MessageBox.Show("Herhangi bir Kayıt Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ögretmen_Ekle_Load(object sender, EventArgs e)
        {
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
    }
}
