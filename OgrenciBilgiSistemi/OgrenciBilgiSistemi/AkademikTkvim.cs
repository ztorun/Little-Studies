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
    public partial class AkademikTkvim : Form
    {
        public AkademikTkvim()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* Bu kısımda ıse altta belırttıgım gıbı tek tek sayfalara yonlendırıyorum lınklabelın clıck olayına. */
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2013-2014/2013_2014onlisans_lisans.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2013-2014/2013_2014tip.pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2013-2014/2013_2014dishek.pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2013-2014/2013_2014yukseklisans.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2012-2013/2012_2013onlisans_lisans.pdf");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rize.edu.tr/akademik_takvim/2012-2013/2012_2013tip.pdf");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(" http://www.rize.edu.tr/akademik_takvim/2012-2013/2012_2013yukseklisans.pdf");
        }

        private void AkademikTkvim_Load(object sender, EventArgs e)
        {

        }
    }
}
