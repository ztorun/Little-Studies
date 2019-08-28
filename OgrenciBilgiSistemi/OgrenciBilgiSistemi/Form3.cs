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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.TblAkademikTableAdapter.Fill(this.DataSet1.TblAkademik);
            //crystal report veri tabanına bağlama
            this.reportViewer1.RefreshReport();
           // crystal report sayfaya döktürme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TblAkademikTableAdapter.FillBy(this.DataSet1.TblAkademik , textBox1.Text );
            //crystal report veri tabanına bağlama ama değerleri belirli isteğe göre döktürme
            this.reportViewer1.RefreshReport();
            //crystal report sayfaya döktürme
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
