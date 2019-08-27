namespace Görsel2_Proje_SinemaOtomasyon
{
    partial class anaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_adminPanel = new System.Windows.Forms.ToolStripButton();
            this.tsb_biletSatis = new System.Windows.Forms.ToolStripButton();
            this.tsb_biletSorgula = new System.Windows.Forms.ToolStripButton();
            this.tsb_kullaniciEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_adminPanel,
            this.tsb_biletSatis,
            this.tsb_biletSorgula,
            this.tsb_kullaniciEkle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_adminPanel
            // 
            this.tsb_adminPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_adminPanel.Name = "tsb_adminPanel";
            this.tsb_adminPanel.Size = new System.Drawing.Size(79, 22);
            this.tsb_adminPanel.Text = "Admin Panel";
            this.tsb_adminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_adminPanel.Click += new System.EventHandler(this.tsb_adminPanel_Click);
            // 
            // tsb_biletSatis
            // 
            this.tsb_biletSatis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_biletSatis.Image = ((System.Drawing.Image)(resources.GetObject("tsb_biletSatis.Image")));
            this.tsb_biletSatis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_biletSatis.Name = "tsb_biletSatis";
            this.tsb_biletSatis.Size = new System.Drawing.Size(61, 22);
            this.tsb_biletSatis.Text = "Bilet Satış";
            this.tsb_biletSatis.Click += new System.EventHandler(this.tsb_biletSatis_Click);
            // 
            // tsb_biletSorgula
            // 
            this.tsb_biletSorgula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_biletSorgula.Image = ((System.Drawing.Image)(resources.GetObject("tsb_biletSorgula.Image")));
            this.tsb_biletSorgula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_biletSorgula.Name = "tsb_biletSorgula";
            this.tsb_biletSorgula.Size = new System.Drawing.Size(94, 22);
            this.tsb_biletSorgula.Text = "Bilet Sorgulama";
            this.tsb_biletSorgula.Click += new System.EventHandler(this.tsb_biletSorgula_Click);
            // 
            // tsb_kullaniciEkle
            // 
            this.tsb_kullaniciEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_kullaniciEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kullaniciEkle.Image")));
            this.tsb_kullaniciEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kullaniciEkle.Name = "tsb_kullaniciEkle";
            this.tsb_kullaniciEkle.Size = new System.Drawing.Size(80, 22);
            this.tsb_kullaniciEkle.Text = "Kullanıcı Ekle";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 354);
            this.Controls.Add(this.toolStrip1);
            this.Name = "anaForm";
            this.Text = "anaForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_adminPanel;
        private System.Windows.Forms.ToolStripButton tsb_biletSatis;
        private System.Windows.Forms.ToolStripButton tsb_biletSorgula;
        private System.Windows.Forms.ToolStripButton tsb_kullaniciEkle;
    }
}