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
    public partial class ŞifremiUnuttum : Form
    {
        public ŞifremiUnuttum()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();


        public void onayla()
        {
            try
            {
                if (textBox2.Text == dataGridView1.Rows[0].Cells[2].Value.ToString())
                {
                    MessageBox.Show("Dogru Cevap");
                    YeniŞifre acıyom = new YeniŞifre();
                    this.Hide();
                    acıyom.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Yanlış Cevap");
                    textBox2.Text = "";

                    return;
                }
            }

            catch
            {
                MessageBox.Show("Bu Hatayı Aldırabilmen Büyük Başarı Sizi Kutluyoruz");
            }
        
        }
        
        private void ŞifremiUnuttum_Load(object sender, EventArgs e)
        {

            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From GizliSoruVerisi", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "GizliSoruVerisi");

            dataGridView1.DataSource = dtst.Tables["GizliSoruVerisi"];

            adtr.Dispose();
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox3.Text= dataGridView1.Rows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            connect.Open();
            onayla();
            connect.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
            {
                connect.Open();
                onayla();
                connect.Close();
            }
        }
    }
}
