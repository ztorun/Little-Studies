using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Görsel2_Proje_SinemaOtomasyon
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void tsb_adminPanel_Click(object sender, EventArgs e)
        {
            adminPanel adfrm = new adminPanel();
            adfrm.Show();
        }

        private void tsb_biletSatis_Click(object sender, EventArgs e)
        {
            Bilet_Satis bsfrm = new Bilet_Satis();
            bsfrm.Show();
        }

        private void tsb_biletSorgula_Click(object sender, EventArgs e)
        {
            
        }
    }
}
