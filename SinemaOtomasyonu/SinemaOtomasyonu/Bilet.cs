using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VTIslemleri;

namespace SinemaOtomasyonu
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        private void Bilet_Load(object sender, EventArgs e)
        {
            comb_filmad.DataSource = vt.Select("select film_id,film_ad from tbl_filmler ");
            comb_filmad.DisplayMember = "film_ad";
            comb_filmad.ValueMember = "film_id";
            comb_filmad.SelectedIndex = -1;
           

            comb_salon.DataSource = vt.Select("select salon_id,salon_ad from tbl_salon");
            comb_salon.DisplayMember = "salon_ad";
            comb_salon.ValueMember = "salon_id";
            comb_salon.SelectedIndex = -1;


            comb_seansTarih.DataSource = vt.Select("select seans_id,seanstarih,seanssaat,sinema_id,film_id,salon_id from tbl_seans");
            comb_seansTarih.DisplayMember = "seanstarih";
            comb_seansTarih.ValueMember = "seans_id";
            comb_seansTarih.DataSource = vt.Select("select seans_id,seanstarih,seanssaat,sinema_id,film_id,salon_id from tbl_seans where seanstarih='"+comb_seansTarih.SelectedValue+"'");
            comb_seans.DisplayMember = "seanssaat";
            comb_seans.ValueMember = "seans_id";


            
        }

        String[] dizi = new string[70];
        int koltuksay = 0;
        
        private void G2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            dizi[koltuksay] = btn.Name;
            if (btn.BackColor == Color.Brown)
            {
                btn.BackColor = Color.PaleGreen;

                tx_koltuk.Text = "";//tekrarı engelle

                foreach (Button b in groupBox1.Controls)
                {
                    if (b.BackColor == Color.Brown)
                    {
                        tx_koltuk.Text += b.Name + ";";
                        
                        //lst_koltuk.Items.Remove(dizi[koltuksay]);//sill

                    }
                }
            }
            else
            {
                btn.BackColor = Color.Brown;

                tx_koltuk.Text += btn.Name.ToString() + "-";


                int sayi = vt.Insert(@"insert into tbl_koltuk(koltuk_ad)values('"+btn.Name.ToString()+"')");
               // tx_koltuk.Items.Add(dizi[koltuksay]);

            }
            koltuksay++;
            
        }
    }
}
