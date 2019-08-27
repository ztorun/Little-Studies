namespace Görsel2_Proje_SinemaOtomasyon
{
    partial class kulGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kulAd = new System.Windows.Forms.TextBox();
            this.tx_parola = new System.Windows.Forms.TextBox();
            this.rb_yonetici = new System.Windows.Forms.RadioButton();
            this.rb_kullanici = new System.Windows.Forms.RadioButton();
            this.btn_yeniKayit = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola :";
            // 
            // tx_kulAd
            // 
            this.tx_kulAd.Location = new System.Drawing.Point(102, 58);
            this.tx_kulAd.Name = "tx_kulAd";
            this.tx_kulAd.Size = new System.Drawing.Size(133, 20);
            this.tx_kulAd.TabIndex = 2;
            // 
            // tx_parola
            // 
            this.tx_parola.Location = new System.Drawing.Point(102, 89);
            this.tx_parola.Name = "tx_parola";
            this.tx_parola.Size = new System.Drawing.Size(133, 20);
            this.tx_parola.TabIndex = 3;
            // 
            // rb_yonetici
            // 
            this.rb_yonetici.AutoSize = true;
            this.rb_yonetici.Location = new System.Drawing.Point(102, 115);
            this.rb_yonetici.Name = "rb_yonetici";
            this.rb_yonetici.Size = new System.Drawing.Size(63, 17);
            this.rb_yonetici.TabIndex = 4;
            this.rb_yonetici.TabStop = true;
            this.rb_yonetici.Text = "Yönetici";
            this.rb_yonetici.UseVisualStyleBackColor = true;
            // 
            // rb_kullanici
            // 
            this.rb_kullanici.AutoSize = true;
            this.rb_kullanici.Location = new System.Drawing.Point(171, 115);
            this.rb_kullanici.Name = "rb_kullanici";
            this.rb_kullanici.Size = new System.Drawing.Size(64, 17);
            this.rb_kullanici.TabIndex = 5;
            this.rb_kullanici.TabStop = true;
            this.rb_kullanici.Text = "Kullanıcı";
            this.rb_kullanici.UseVisualStyleBackColor = true;
            // 
            // btn_yeniKayit
            // 
            this.btn_yeniKayit.Location = new System.Drawing.Point(102, 138);
            this.btn_yeniKayit.Name = "btn_yeniKayit";
            this.btn_yeniKayit.Size = new System.Drawing.Size(63, 40);
            this.btn_yeniKayit.TabIndex = 6;
            this.btn_yeniKayit.Text = "Yeni Kayıt";
            this.btn_yeniKayit.UseVisualStyleBackColor = true;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(171, 140);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(64, 38);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // kulGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_yeniKayit);
            this.Controls.Add(this.rb_kullanici);
            this.Controls.Add(this.rb_yonetici);
            this.Controls.Add(this.tx_parola);
            this.Controls.Add(this.tx_kulAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kulGiris";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kulAd;
        private System.Windows.Forms.TextBox tx_parola;
        private System.Windows.Forms.RadioButton rb_yonetici;
        private System.Windows.Forms.RadioButton rb_kullanici;
        private System.Windows.Forms.Button btn_yeniKayit;
        private System.Windows.Forms.Button btn_giris;
    }
}

