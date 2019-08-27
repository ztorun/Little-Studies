namespace SinemaOtomasyonu
{
    partial class Aktor
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
            this.components = new System.ComponentModel.Container();
            this.lstw_aktor = new System.Windows.Forms.ListView();
            this.aktor_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aktor_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aktor_soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogumTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filmler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.ogrenciBilgi = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_filmleri = new System.Windows.Forms.TextBox();
            this.dtp_dogumTar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_aktorSoyad = new System.Windows.Forms.TextBox();
            this.tx_aktorAdi = new System.Windows.Forms.TextBox();
            this.tx_aktorno = new System.Windows.Forms.TextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.ep_hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.ogrenciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_hata)).BeginInit();
            this.SuspendLayout();
            // 
            // lstw_aktor
            // 
            this.lstw_aktor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aktor_id,
            this.aktor_ad,
            this.aktor_soyad,
            this.dogumTar,
            this.Filmler});
            this.lstw_aktor.FullRowSelect = true;
            this.lstw_aktor.Location = new System.Drawing.Point(66, 56);
            this.lstw_aktor.Name = "lstw_aktor";
            this.lstw_aktor.Size = new System.Drawing.Size(471, 255);
            this.lstw_aktor.TabIndex = 39;
            this.lstw_aktor.UseCompatibleStateImageBehavior = false;
            this.lstw_aktor.View = System.Windows.Forms.View.Details;
            // 
            // aktor_id
            // 
            this.aktor_id.Text = "Aktor ID";
            this.aktor_id.Width = 97;
            // 
            // aktor_ad
            // 
            this.aktor_ad.Text = "Aktor Adı";
            this.aktor_ad.Width = 98;
            // 
            // aktor_soyad
            // 
            this.aktor_soyad.Text = "Aktor Soyad";
            this.aktor_soyad.Width = 97;
            // 
            // dogumTar
            // 
            this.dogumTar.Text = "Doğum Tarihi";
            this.dogumTar.Width = 99;
            // 
            // Filmler
            // 
            this.Filmler.Text = "Filmler";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(462, 288);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 38;
            this.btn_kaydet.Text = "kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Visible = false;
            // 
            // ogrenciBilgi
            // 
            this.ogrenciBilgi.BackColor = System.Drawing.Color.Transparent;
            this.ogrenciBilgi.Controls.Add(this.label5);
            this.ogrenciBilgi.Controls.Add(this.tx_filmleri);
            this.ogrenciBilgi.Controls.Add(this.dtp_dogumTar);
            this.ogrenciBilgi.Controls.Add(this.label4);
            this.ogrenciBilgi.Controls.Add(this.label3);
            this.ogrenciBilgi.Controls.Add(this.label2);
            this.ogrenciBilgi.Controls.Add(this.label1);
            this.ogrenciBilgi.Controls.Add(this.tx_aktorSoyad);
            this.ogrenciBilgi.Controls.Add(this.tx_aktorAdi);
            this.ogrenciBilgi.Controls.Add(this.tx_aktorno);
            this.ogrenciBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciBilgi.ForeColor = System.Drawing.Color.White;
            this.ogrenciBilgi.Location = new System.Drawing.Point(559, 56);
            this.ogrenciBilgi.Name = "ogrenciBilgi";
            this.ogrenciBilgi.Size = new System.Drawing.Size(250, 255);
            this.ogrenciBilgi.TabIndex = 40;
            this.ogrenciBilgi.TabStop = false;
            this.ogrenciBilgi.Text = "Aktor Bilgileri";
            this.ogrenciBilgi.Enter += new System.EventHandler(this.ogrenciBilgi_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filmleri:";
            // 
            // tx_filmleri
            // 
            this.tx_filmleri.Location = new System.Drawing.Point(129, 218);
            this.tx_filmleri.Name = "tx_filmleri";
            this.tx_filmleri.Size = new System.Drawing.Size(100, 21);
            this.tx_filmleri.TabIndex = 20;
            // 
            // dtp_dogumTar
            // 
            this.dtp_dogumTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dogumTar.Location = new System.Drawing.Point(128, 173);
            this.dtp_dogumTar.Name = "dtp_dogumTar";
            this.dtp_dogumTar.Size = new System.Drawing.Size(100, 21);
            this.dtp_dogumTar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aktor Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Aktor Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Aktor No:";
            // 
            // tx_aktorSoyad
            // 
            this.tx_aktorSoyad.Location = new System.Drawing.Point(128, 122);
            this.tx_aktorSoyad.Name = "tx_aktorSoyad";
            this.tx_aktorSoyad.Size = new System.Drawing.Size(100, 21);
            this.tx_aktorSoyad.TabIndex = 2;
            // 
            // tx_aktorAdi
            // 
            this.tx_aktorAdi.Location = new System.Drawing.Point(128, 76);
            this.tx_aktorAdi.Name = "tx_aktorAdi";
            this.tx_aktorAdi.Size = new System.Drawing.Size(100, 21);
            this.tx_aktorAdi.TabIndex = 1;
            // 
            // tx_aktorno
            // 
            this.tx_aktorno.Location = new System.Drawing.Point(128, 27);
            this.tx_aktorno.Name = "tx_aktorno";
            this.tx_aktorno.Size = new System.Drawing.Size(100, 21);
            this.tx_aktorno.TabIndex = 0;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_güncelle.Location = new System.Drawing.Point(234, 342);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(121, 54);
            this.btn_güncelle.TabIndex = 36;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sil.Location = new System.Drawing.Point(494, 342);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 54);
            this.btn_sil.TabIndex = 37;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ekle.Location = new System.Drawing.Point(365, 342);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 54);
            this.btn_ekle.TabIndex = 35;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            // 
            // ep_hata
            // 
            this.ep_hata.ContainerControl = this;
            // 
            // Aktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(874, 453);
            this.Controls.Add(this.lstw_aktor);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.ogrenciBilgi);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Aktor";
            this.Text = "Aktor";
            this.ogrenciBilgi.ResumeLayout(false);
            this.ogrenciBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_hata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lstw_aktor;
        public System.Windows.Forms.ColumnHeader aktor_id;
        public System.Windows.Forms.ColumnHeader aktor_ad;
        public System.Windows.Forms.ColumnHeader aktor_soyad;
        public System.Windows.Forms.ColumnHeader dogumTar;
        public System.Windows.Forms.ColumnHeader Filmler;
        private System.Windows.Forms.Button btn_kaydet;
        public System.Windows.Forms.GroupBox ogrenciBilgi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_filmleri;
        private System.Windows.Forms.DateTimePicker dtp_dogumTar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_aktorSoyad;
        private System.Windows.Forms.TextBox tx_aktorAdi;
        private System.Windows.Forms.TextBox tx_aktorno;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ErrorProvider ep_hata;
    }
}