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
    public partial class DrsProg : Form
    {
        public DrsProg()
        {
            InitializeComponent();
        }

        private void DrsProg_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Aşşağıdaki Kısımda Eğer Combobox1 Bilgisayar Prog 1/1.ogr degerı Rsm Klasorundekı bılgısayar1.1.jpg resmini çağırıyoruz ve alttaki işlemlerdede bunu demek ıstedım ıf else yöntemiyle. */
                if  (comboBox1.Text == "Bilgisayar Prog 1/1.ogr") pictureBox1.ImageLocation = "Rsm/bilgisayar1.1.jpg";

                else if (comboBox1.Text == "Bilgisayar Prog 1/2.ogr") pictureBox1.ImageLocation = "Rsm/bilgisayar1.2.jpg";

                else if (comboBox1.Text == "Bilgisayar Prog 2/1.ogr") pictureBox1.ImageLocation = "Rsm/bilgisayar2.1.jpg";

                else if (comboBox1.Text == "Bilgisayar Prog 2/2.ogr") pictureBox1.ImageLocation = "Rsm/bilgisayar2.2.jpg";

                else if (comboBox1.Text == "Elektrik 1/1.ogr") pictureBox1.ImageLocation = "Rsm/elektrik1.1.jpg";

                else if (comboBox1.Text == "Elektrik 1/2.ogr") pictureBox1.ImageLocation = "Rsm/elektrik1.2.jpg";

                else if (comboBox1.Text == "İnşaat 1/1.ogr") pictureBox1.ImageLocation = "Rsm/İnsaat1.1.jpg";

                else if (comboBox1.Text == "İnşaat 1/2.ogr") pictureBox1.ImageLocation = "Rsm/İnsaat1.2.jpg";

                else if (comboBox1.Text == "İnşaat 2/1.ogr") pictureBox1.ImageLocation = "Rsm/İnsaat2.1.jpg";

                else if (comboBox1.Text == "İnşaat 2/2.ogr") pictureBox1.ImageLocation = "Rsm/İnsaat2.2.jpg";

                else if (comboBox1.Text == "Makine 1/1.ogr") pictureBox1.ImageLocation = "Rsm/Makine1.1.jpg";

                else if (comboBox1.Text == "Makine 1/2.ogr") pictureBox1.ImageLocation = "Rsm/Makine1.2.jpg";

                else if (comboBox1.Text == "Makine 2/1.ogr") pictureBox1.ImageLocation = "Rsm/Makine2.1.jpg";

                else if (comboBox1.Text == "Makine 2/2.ogr") pictureBox1.ImageLocation = "Rsm/Makine2.2.jpg";

                    /*Eğer bunlar degılse messagebox.show ile listede mevcut degıl Uyarısı çıkartıyoruz.*/
                else  MessageBox.Show("Listede mevcut değil !","Hata");
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* Pıcturebox2 deki yazdır ıconuna tıklayıp formu yazdırabılıyoruz.*/
            this.printDialog1.ShowDialog();
        }
    }
}
