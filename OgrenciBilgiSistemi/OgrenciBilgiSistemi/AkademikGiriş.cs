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
    public partial class AkademikGiriş : Form
    {
        public AkademikGiriş()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            if (TxtAdd.Text == "Admin" && TxtSifree.Text == "a65096509") 
                /* Eğer TxtAdd'a Admin değeri girilip TxtSifree'ye ise a65096509 Giriliyosa  Admin Paneline Yönlendirsin  demişim . */
            {
                AdminPaneli yeni = new AdminPaneli();
                yeni.Show();
                Hide();
            }

                  else 
            {
                /*Değilse bana hata mesajı belirtsin.*/
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre Girdiniz","HATA" , MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            }

        private void AkademikGiriş_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Linklabel1 e bastıktan sonra benı form1 e yönlendırsın demişim*/
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
        }
    }
