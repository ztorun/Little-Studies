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
    public partial class YeniŞifre : Form
    {
        public YeniŞifre()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
       
        private void YeniŞifre_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Yönetici", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Yönetici");

            dataGridView1.DataSource = dtst.Tables["Yönetici"];
            textBox3.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            adtr.Dispose();
        }
        public void onaylıyorum()
        {
            try
            {
                int a = 0, b = 0;
                if (textBox1.Text == textBox2.Text)
                {

                    if (textBox4.Text == textBox5.Text)
                    {
                        OleDbCommand güncelle = new OleDbCommand("update Yönetici set KullanıcıAdı='" + textBox1.Text + "' where Sıra ='" + textBox3.Text + "'", connect);

                        güncelle.ExecuteNonQuery();
                        b++;

                    }
                    else
                    {
                        a++;
                        MessageBox.Show("Yeni Şifre Ve Şifre Tekrar Kısmı Aynı Degil");
                        return;
                    }
                }
                else
                {
                    a++;
                    MessageBox.Show("Yeni Kullanıcı Adı Ve Kullanıcı Adı Tekrar Kısmı Aynı Degil");
                    return;
                }

                if (a == 0)
                {
                    OleDbCommand güncelle2 = new OleDbCommand("update Yönetici set Parola='" + textBox4.Text + "' where Sıra ='" + textBox3.Text + "'", connect);

                    güncelle2.ExecuteNonQuery();
                    b++;

                }
                if (b == 2)
                {
                    MessageBox.Show("Kullanıcı Adı Ve Şifre Kaydedilmiştir");


                    this.Close();

                }
            }

            catch
            {
                MessageBox.Show("Siz İmkansızı Başarıp Programa Hata Verdirttiniz Tebrik Ederiz");
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            onaylıyorum();
            
            connect.Close();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                connect.Open();
                onaylıyorum();
                connect.Close();
            }
        }
    }
}
