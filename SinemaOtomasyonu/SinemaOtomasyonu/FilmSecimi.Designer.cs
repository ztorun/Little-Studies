namespace SinemaOtomasyonu
{
    partial class FilmSecimi
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_digerseans = new System.Windows.Forms.Button();
            this.cm_salon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_seans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.tx_secilenfilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lstw_seanslar = new System.Windows.Forms.ListView();
            this.btn_seansSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(370, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 59);
            this.button1.TabIndex = 34;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_digerseans
            // 
            this.btn_digerseans.AccessibleDescription = "";
            this.btn_digerseans.Location = new System.Drawing.Point(403, 43);
            this.btn_digerseans.Name = "btn_digerseans";
            this.btn_digerseans.Size = new System.Drawing.Size(122, 32);
            this.btn_digerseans.TabIndex = 33;
            this.btn_digerseans.Text = "Filmin diğer seansları";
            this.btn_digerseans.UseVisualStyleBackColor = true;
            // 
            // cm_salon
            // 
            this.cm_salon.FormattingEnabled = true;
            this.cm_salon.Location = new System.Drawing.Point(202, 132);
            this.cm_salon.Name = "cm_salon";
            this.cm_salon.Size = new System.Drawing.Size(141, 21);
            this.cm_salon.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "seans:";
            // 
            // tx_seans
            // 
            this.tx_seans.Location = new System.Drawing.Point(202, 275);
            this.tx_seans.Name = "tx_seans";
            this.tx_seans.Size = new System.Drawing.Size(100, 20);
            this.tx_seans.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tarih:";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(202, 201);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(171, 20);
            this.dtp_tarih.TabIndex = 28;
            // 
            // tx_secilenfilm
            // 
            this.tx_secilenfilm.Enabled = false;
            this.tx_secilenfilm.Location = new System.Drawing.Point(202, 43);
            this.tx_secilenfilm.Name = "tx_secilenfilm";
            this.tx_secilenfilm.Size = new System.Drawing.Size(141, 20);
            this.tx_secilenfilm.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Salon Seçimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Secilen Film:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(96, 352);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(212, 59);
            this.btn_kaydet.TabIndex = 24;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // lstw_seanslar
            // 
            this.lstw_seanslar.Location = new System.Drawing.Point(576, 46);
            this.lstw_seanslar.Name = "lstw_seanslar";
            this.lstw_seanslar.Size = new System.Drawing.Size(283, 252);
            this.lstw_seanslar.TabIndex = 35;
            this.lstw_seanslar.UseCompatibleStateImageBehavior = false;
            this.lstw_seanslar.View = System.Windows.Forms.View.Details;
            // 
            // btn_seansSil
            // 
            this.btn_seansSil.Location = new System.Drawing.Point(403, 111);
            this.btn_seansSil.Name = "btn_seansSil";
            this.btn_seansSil.Size = new System.Drawing.Size(122, 42);
            this.btn_seansSil.TabIndex = 36;
            this.btn_seansSil.Text = "Seans Sil";
            this.btn_seansSil.UseVisualStyleBackColor = true;
            // 
            // FilmSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 455);
            this.Controls.Add(this.btn_seansSil);
            this.Controls.Add(this.lstw_seanslar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_digerseans);
            this.Controls.Add(this.cm_salon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_seans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.tx_secilenfilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "FilmSecimi";
            this.Text = "FilmSecimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_digerseans;
        public System.Windows.Forms.ComboBox cm_salon;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tx_seans;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtp_tarih;
        public System.Windows.Forms.TextBox tx_secilenfilm;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_kaydet;
        public System.Windows.Forms.ListView lstw_seanslar;
        public System.Windows.Forms.Button btn_seansSil;
    }
}