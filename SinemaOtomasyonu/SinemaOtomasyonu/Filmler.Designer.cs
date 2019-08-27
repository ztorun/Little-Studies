namespace SinemaOtomasyonu
{
    partial class Filmler
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtp_vizyonTar = new System.Windows.Forms.DateTimePicker();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_sure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_yapim = new System.Windows.Forms.TextBox();
            this.tx_filmAdi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tx_filmNo = new System.Windows.Forms.TextBox();
            this.sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_secilen = new System.Windows.Forms.Button();
            this.cm_filmler = new System.Windows.Forms.ComboBox();
            this.lstw_film = new System.Windows.Forms.ListView();
            this.film_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.film_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vizyonTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yapim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 65;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_güncelle.Location = new System.Drawing.Point(395, 239);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(121, 54);
            this.btn_güncelle.TabIndex = 59;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sil.Location = new System.Drawing.Point(395, 403);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 54);
            this.btn_sil.TabIndex = 60;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ekle.Location = new System.Drawing.Point(395, 325);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 54);
            this.btn_ekle.TabIndex = 58;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            // 
            // dtp_vizyonTar
            // 
            this.dtp_vizyonTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vizyonTar.Location = new System.Drawing.Point(128, 126);
            this.dtp_vizyonTar.Name = "dtp_vizyonTar";
            this.dtp_vizyonTar.Size = new System.Drawing.Size(100, 21);
            this.dtp_vizyonTar.TabIndex = 21;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(458, 189);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 61;
            this.btn_kaydet.Text = "kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtp_vizyonTar);
            this.groupBox1.Controls.Add(this.tx_sure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tx_yapim);
            this.groupBox1.Controls.Add(this.tx_filmAdi);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tx_filmNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(74, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 255);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Bilgilerini Girin";
            // 
            // tx_sure
            // 
            this.tx_sure.ForeColor = System.Drawing.Color.DarkGray;
            this.tx_sure.Location = new System.Drawing.Point(128, 203);
            this.tx_sure.Name = "tx_sure";
            this.tx_sure.Size = new System.Drawing.Size(100, 21);
            this.tx_sure.TabIndex = 20;
            this.tx_sure.Text = "? dakika..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(28, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yapım:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vizyon Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Film Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Film ID:";
            // 
            // tx_yapim
            // 
            this.tx_yapim.Location = new System.Drawing.Point(128, 165);
            this.tx_yapim.Name = "tx_yapim";
            this.tx_yapim.Size = new System.Drawing.Size(100, 21);
            this.tx_yapim.TabIndex = 3;
            // 
            // tx_filmAdi
            // 
            this.tx_filmAdi.Location = new System.Drawing.Point(128, 84);
            this.tx_filmAdi.Name = "tx_filmAdi";
            this.tx_filmAdi.Size = new System.Drawing.Size(100, 21);
            this.tx_filmAdi.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 13;
            // 
            // tx_filmNo
            // 
            this.tx_filmNo.Location = new System.Drawing.Point(128, 39);
            this.tx_filmNo.Name = "tx_filmNo";
            this.tx_filmNo.Size = new System.Drawing.Size(100, 21);
            this.tx_filmNo.TabIndex = 0;
            // 
            // sure
            // 
            this.sure.Text = "Süre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_secilen);
            this.groupBox2.Controls.Add(this.cm_filmler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(561, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 182);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filme Gösterim Bilgilerini ayarlaynın";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Film Adı:";
            // 
            // btn_secilen
            // 
            this.btn_secilen.ForeColor = System.Drawing.Color.Black;
            this.btn_secilen.Location = new System.Drawing.Point(101, 107);
            this.btn_secilen.Name = "btn_secilen";
            this.btn_secilen.Size = new System.Drawing.Size(121, 53);
            this.btn_secilen.TabIndex = 42;
            this.btn_secilen.Text = "seans ayarla";
            this.btn_secilen.UseVisualStyleBackColor = true;
            // 
            // cm_filmler
            // 
            this.cm_filmler.FormattingEnabled = true;
            this.cm_filmler.Location = new System.Drawing.Point(101, 40);
            this.cm_filmler.Name = "cm_filmler";
            this.cm_filmler.Size = new System.Drawing.Size(154, 21);
            this.cm_filmler.TabIndex = 0;
            // 
            // lstw_film
            // 
            this.lstw_film.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.film_id,
            this.film_ad,
            this.vizyonTarihi,
            this.yapim,
            this.sure});
            this.lstw_film.FullRowSelect = true;
            this.lstw_film.Location = new System.Drawing.Point(45, 12);
            this.lstw_film.Name = "lstw_film";
            this.lstw_film.Size = new System.Drawing.Size(488, 200);
            this.lstw_film.TabIndex = 62;
            this.lstw_film.UseCompatibleStateImageBehavior = false;
            this.lstw_film.View = System.Windows.Forms.View.Details;
            // 
            // film_id
            // 
            this.film_id.Text = "Film ID";
            this.film_id.Width = 97;
            // 
            // film_ad
            // 
            this.film_ad.Text = "Film adı";
            this.film_ad.Width = 98;
            // 
            // vizyonTarihi
            // 
            this.vizyonTarihi.Text = "Vizyon Tarihi";
            this.vizyonTarihi.Width = 97;
            // 
            // yapim
            // 
            this.yapim.Text = "Yapım";
            this.yapim.Width = 99;
            // 
            // Filmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(943, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstw_film);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "Filmler";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.Filmler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_güncelle;
        public System.Windows.Forms.Button btn_sil;
        public System.Windows.Forms.Button btn_ekle;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DateTimePicker dtp_vizyonTar;
        public System.Windows.Forms.Button btn_kaydet;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tx_sure;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tx_yapim;
        public System.Windows.Forms.TextBox tx_filmAdi;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox tx_filmNo;
        public System.Windows.Forms.ColumnHeader sure;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_secilen;
        public System.Windows.Forms.ComboBox cm_filmler;
        public System.Windows.Forms.ListView lstw_film;
        public System.Windows.Forms.ColumnHeader film_id;
        public System.Windows.Forms.ColumnHeader film_ad;
        public System.Windows.Forms.ColumnHeader vizyonTarihi;
        public System.Windows.Forms.ColumnHeader yapim;
    }
}