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
    public partial class kulGiris : Form
    {
        public kulGiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            anaForm afrm = new anaForm();
            afrm.Show();
        }
    }
}
