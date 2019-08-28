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
    public partial class Ödev_Ekle : Form
    {
        public Ödev_Ekle()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string ekle = "Insert into ÖdevTablo (Ders,Ödev,verilis) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "')";
            OleDbCommand cmd = new OleDbCommand(ekle, connect);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Ödev Başarı Birşekilde Kaydedilmiştir");
            connect.Close();
        }

        private void Ödev_Ekle_Load(object sender, EventArgs e)
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
