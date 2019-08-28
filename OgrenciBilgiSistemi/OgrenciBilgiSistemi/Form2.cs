using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış Yapmak İstediğinize Eminmisiniz ?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Öğrenci Bilgi Sisteminden Çıkış Yapmadınız.","Bilgi");
            }

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AkademikTkvim form2 = new AkademikTkvim();
            form2.Show();
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NotGorntleme form3 = new NotGorntleme();
            form3.Show();
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrsProg form4 = new DrsProg();
            form4.Show();
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sinavprog form5 = new Sinavprog();
            form5.Show();
           
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Devamsizlik form6 = new Devamsizlik();
            form6.Show();
          
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Refresh(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            lblAdiSoyadi.Text = OgrenciBilgi.Ad + " " + OgrenciBilgi.Soyad;
        }

        private void lblAdiSoyadi_Click(object sender, EventArgs e)
        {

        }
    }
}
