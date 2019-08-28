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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        public void sifregiris()
        {
            try
            {
                if (textBox1.Text == dataGridView1.Rows[0].Cells[1].Value.ToString())
                {
                    if (textBox2.Text == dataGridView1.Rows[0].Cells[2].Value.ToString())
                    {
                        
                            if (dataGridView2.Rows[0].Cells[4].Value.ToString() == "0")
                            {
                                ÖgrenciTakip ac = new ÖgrenciTakip();
                              this.Hide();  
                                ac.ShowDialog();
                                this.Close();
                               
                            }


                            else if (dataGridView2.Rows[0].Cells[4].Value.ToString() == "1")
                            {
                                Okul_Takip ac = new Okul_Takip();
                                this.Hide(); 
                                ac.ShowDialog();
                                this.Close();
                               
                            }

                    }
                    else
                    {
                        MessageBox.Show("Girilen Ögeler Yanlış Şifremi Unuttumda Gizli Sorunuz İle Şifrenizi Yenileyebilirsiniz");
                    }


                }
                else
                {
                    MessageBox.Show("Girilen Ögeler Yanlış Şifremi Unuttumda Gizli Sorunuz İle Şifrenizi Yenileyebilirsiniz");
                }
            }
            catch
            {
                MessageBox.Show("Eyvah Hata Artık Bu Program İflak Olmaz Lütfen Tekrar Yükleyini");
            }
        
        
        
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Yönetici", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Yönetici");

            dataGridView1.DataSource = dtst.Tables["Yönetici"];

            adtr.Dispose();


            OleDbDataAdapter adtr2 = new OleDbDataAdapter("select * From GizliSoruVerisi", connect);
            DataSet dtst2 = new DataSet();


            adtr2.Fill(dtst2, "GizliSoruVerisi");

            dataGridView2.DataSource = dtst2.Tables["GizliSoruVerisi"];

            adtr2.Dispose();
            if (dataGridView2.Rows[0].Cells[3].Value.ToString() == "0")
            {
                if (dataGridView2.Rows[0].Cells[4].Value.ToString() == "0")
                {
                    ÖgrenciTakip ac = new ÖgrenciTakip();
                    ac.ShowDialog();
                    this.Close();
                }


                else if (dataGridView2.Rows[0].Cells[4].Value.ToString() == "1")
                {
                    Okul_Takip ac = new Okul_Takip();
                    ac.ShowDialog();
                    this.Close();
                }
            
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            sifregiris();
           
              connect.Close();
              this.Hide();
     
              this.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
             connect.Open();

            try
            {
                if (textBox1.Text == dataGridView1.Rows[0].Cells[1].Value.ToString())
                {
                    if (textBox2.Text == dataGridView1.Rows[0].Cells[2].Value.ToString())
                    {
                  
                        Ayarlar ac = new Ayarlar();

                 
                        ac.ShowDialog();
                     

                    }
                    else
                    {
                        MessageBox.Show("Girilen Ögeler Yanlış Şifremi Unuttumda Gizli Sorunuz İle Şifrenizi Yenileyebilirsiniz");
                    }


                }
                else
                {
                    MessageBox.Show("Girilen Ögeler Yanlış Şifremi Unuttumda Gizli Sorunuz İle Şifrenizi Yenileyebilirsiniz");
                }
            }
            catch 
            
            {
                MessageBox.Show("Eyvah Hata Artık Bu Program İflak Olmaz Lütfen Tekrar Yükleyiniz");
            }
              connect.Close();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ŞifremiUnuttum acıver = new ŞifremiUnuttum();
            acıver.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Yönetici", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Yönetici");

            dataGridView1.DataSource = dtst.Tables["Yönetici"];

            adtr.Dispose();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData.ToString() == "Return")
            {
                connect.Open();
                sifregiris();
                connect.Close();
            }


        
                      
    

        }
        }
    }

