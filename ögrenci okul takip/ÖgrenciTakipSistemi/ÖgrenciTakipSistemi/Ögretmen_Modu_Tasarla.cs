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
    public partial class Ögretmen_Modu_Tasarla : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        public Ögretmen_Modu_Tasarla()
        {
            InitializeComponent();
        }
        Control cc;
        int xx;
        int yy;
        int mx;
        int my;
        void get_cont(Control sender)
        {
            cc = sender;
            mx = Cursor.Position.X;
            my = Cursor.Position.Y;
            xx = mx; yy = my;
            timer1.Enabled = !timer1.Enabled;
        }
       

        private void Ögretmen_Modu_Tasarla_Load(object sender, EventArgs e)
        {
            textBox8.Text = "1";
            connect.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From Tasarla", connect);
            DataSet dtst = new DataSet();

            adtr.Fill(dtst, "Tasarla");

            dataGridView2.DataSource = dtst.Tables["Tasarla"];


            adtr.Dispose();
            connect.Close();



            //kaydet1
            int x = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value);
            int y = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);

            button1.Location = new Point(x, y);
         

            //sıfırla1
            int x1 = Convert.ToInt32(dataGridView2.Rows[0].Cells[3].Value);
            int y1 = Convert.ToInt32(dataGridView2.Rows[0].Cells[4].Value);

            button7.Location = new Point(x1, y1);
           
            //kapat1
            int x2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[5].Value);
            int y2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[6].Value);

            button8.Location = new Point(x2, y2);
            //label27 hoşgeldiniz

            int x3 = Convert.ToInt32(dataGridView2.Rows[0].Cells[7].Value);
            int y3 = Convert.ToInt32(dataGridView2.Rows[0].Cells[8].Value);

            label27.Location = new Point(x3, y3);

            //button3 yenile

            int x4 = Convert.ToInt32(dataGridView2.Rows[0].Cells[9].Value);
            int y4 = Convert.ToInt32(dataGridView2.Rows[0].Cells[10].Value);

            button3.Location = new Point(x4, y4);
            //button 5 kapat2

            int x5 = Convert.ToInt32(dataGridView2.Rows[0].Cells[11].Value);
            int y5 = Convert.ToInt32(dataGridView2.Rows[0].Cells[12].Value);

            button5.Location = new Point(x5, y5);
            
            
            //button6 yenile2
            int x6 = Convert.ToInt32(dataGridView2.Rows[0].Cells[13].Value);
            int y6 = Convert.ToInt32(dataGridView2.Rows[0].Cells[14].Value);

            button6.Location = new Point(x6, y6);



            //button4 kaydet2
            int x7 = Convert.ToInt32(dataGridView2.Rows[0].Cells[15].Value);
            int y7 = Convert.ToInt32(dataGridView2.Rows[0].Cells[16].Value);

            button4.Location = new Point(x7, y7);


            //button9 kapat3
            int x8 = Convert.ToInt32(dataGridView2.Rows[0].Cells[17].Value);
            int y8 = Convert.ToInt32(dataGridView2.Rows[0].Cells[18].Value);

            button9.Location = new Point(x8, y8);

            //button10 resim

        
            int x9 = Convert.ToInt32(dataGridView2.Rows[0].Cells[19].Value);
            int y9 = Convert.ToInt32(dataGridView2.Rows[0].Cells[20].Value);

            button10.Location = new Point(x9, y9);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (cc != null)
                {
                    mx = Cursor.Position.X;
                    my = Cursor.Position.Y;
                    cc.Location = new Point(cc.Location.X + mx - xx, cc.Location.Y + my - yy); xx = mx; yy = my;

                }

            }
            else { timer1.Enabled = false; }
        }

      


     
      



       

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

       

        private void button7_Click_1(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                get_cont((Control)sender);
                return;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            //kaydet1 butonu
            OleDbCommand güncelle1 = new OleDbCommand("update Tasarla set kaydet1X ='" + button1.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle1.ExecuteNonQuery();

            OleDbCommand güncelle2 = new OleDbCommand("update Tasarla set kaydet1Y ='" + button1.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle2.ExecuteNonQuery();

            //sıfırla1 butonu

            OleDbCommand güncelle3 = new OleDbCommand("update Tasarla set sıfırla1X ='" + button7.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle3.ExecuteNonQuery();

            OleDbCommand güncelle4 = new OleDbCommand("update Tasarla set sıfırla1Y ='" + button7.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle4.ExecuteNonQuery();



            //kapat1 butonu
            OleDbCommand güncelle5 = new OleDbCommand("update Tasarla set kapat1X ='" + button8.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle5.ExecuteNonQuery();


            OleDbCommand güncelle6 = new OleDbCommand("update Tasarla set kapat1Y ='" + button8.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle6.ExecuteNonQuery();


            //hoşgeldiniz1
            OleDbCommand güncelle7 = new OleDbCommand("update Tasarla set label27X ='" + label27.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle7.ExecuteNonQuery();


            OleDbCommand güncelle8 = new OleDbCommand("update Tasarla set label27Y ='" + label27.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle8.ExecuteNonQuery();

            //buton3 yenile


            OleDbCommand güncelle9 = new OleDbCommand("update Tasarla set btn3yenileX ='" + button3.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle9.ExecuteNonQuery();


            OleDbCommand güncelle10 = new OleDbCommand("update Tasarla set btn3yenileY ='" + button3.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle10.ExecuteNonQuery();

            //button5 kapat

            OleDbCommand güncelle11 = new OleDbCommand("update Tasarla set kapat2X ='" + button5.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle11.ExecuteNonQuery();


            OleDbCommand güncelle12 = new OleDbCommand("update Tasarla set kapat2Y ='" + button5.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle12.ExecuteNonQuery();

            //buton6 yenile2

            OleDbCommand güncelle13 = new OleDbCommand("update Tasarla set btn6yenile2X ='" + button6.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle13.ExecuteNonQuery();


            OleDbCommand güncelle14 = new OleDbCommand("update Tasarla set btn6yenile2Y ='" + button6.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle14.ExecuteNonQuery();

            //buton4 kaydet2
            OleDbCommand güncelle15 = new OleDbCommand("update Tasarla set btn4kaydet2X ='" + button4.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle15.ExecuteNonQuery();


            OleDbCommand güncelle16 = new OleDbCommand("update Tasarla set btn4kaydet2Y ='" + button4.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle16.ExecuteNonQuery();


            //btn9 kapat3

            OleDbCommand güncelle17 = new OleDbCommand("update Tasarla set  btn9kapat3X ='" + button9.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle17.ExecuteNonQuery();


            OleDbCommand güncelle18 = new OleDbCommand("update Tasarla set  btn9kapat3Y ='" + button9.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle18.ExecuteNonQuery();





            //button10 resim
            OleDbCommand güncelle19 = new OleDbCommand("update Tasarla set   btn10resimX ='" + button10.Location.X.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);


            güncelle19.ExecuteNonQuery();


            OleDbCommand güncelle20 = new OleDbCommand("update Tasarla set   btn10resimY ='" + button10.Location.Y.ToString() + "' where Sıra ='" + textBox8.Text + "'", connect);

            güncelle20.ExecuteNonQuery();


            connect.Close();

        }

        private void button16_Click_1(object sender, EventArgs e)
        {

            button1.Location = new Point(602, 108);

            button7.Location = new Point(602, 57);

            button8.Location = new Point(602, 159);

            label27.Location = new Point(505, 236);

            button3.Location = new Point(379, 27);

            button5.Location = new Point(470, 26);

            button6.Location = new Point(350, 230);

            button4.Location = new Point(458, 228);

            button9.Location = new Point(565, 228);

            button10.Location = new Point(602, 6);
        }

      

        
    }
}
