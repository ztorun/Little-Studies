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
    public partial class Devamsizlik : Form
    {
        public Devamsizlik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Devamsizlik_Load(object sender, EventArgs e)
        {
            label1.Text= OgrenciBilgi.Ad + " " + OgrenciBilgi.Soyad;
            label6.Text= OgrenciBilgi.OgreniNo;
            
        }
    }
}
