using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }
        Kullanici kl = new Kullanici();
        private void tsbtn_Kullanici_Click(object sender, EventArgs e)
        {
            kl.MdiParent = this;
            kl.Show();
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Filmler fm = new Filmler();
            fm.MdiParent = this;
            fm.Show();   
        }
    }
}
