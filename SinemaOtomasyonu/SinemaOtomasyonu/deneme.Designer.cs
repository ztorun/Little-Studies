namespace SinemaOtomasyonu
{
    partial class deneme
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
            this.btn_yaz = new System.Windows.Forms.Button();
            this.tx_teslimeden = new System.Windows.Forms.TextBox();
            this.tx_teslimalan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yaz
            // 
            this.btn_yaz.Location = new System.Drawing.Point(258, 163);
            this.btn_yaz.Name = "btn_yaz";
            this.btn_yaz.Size = new System.Drawing.Size(75, 23);
            this.btn_yaz.TabIndex = 0;
            this.btn_yaz.Text = "yazdır";
            this.btn_yaz.UseVisualStyleBackColor = true;
            this.btn_yaz.Click += new System.EventHandler(this.btn_yaz_Click);
            // 
            // tx_teslimeden
            // 
            this.tx_teslimeden.Location = new System.Drawing.Point(261, 85);
            this.tx_teslimeden.Name = "tx_teslimeden";
            this.tx_teslimeden.Size = new System.Drawing.Size(100, 20);
            this.tx_teslimeden.TabIndex = 1;
            // 
            // tx_teslimalan
            // 
            this.tx_teslimalan.Location = new System.Drawing.Point(261, 123);
            this.tx_teslimalan.Name = "tx_teslimalan";
            this.tx_teslimalan.Size = new System.Drawing.Size(100, 20);
            this.tx_teslimalan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "teslim eden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "teslim alan";
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_teslimalan);
            this.Controls.Add(this.tx_teslimeden);
            this.Controls.Add(this.btn_yaz);
            this.Name = "deneme";
            this.Text = "deneme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yaz;
        private System.Windows.Forms.TextBox tx_teslimeden;
        private System.Windows.Forms.TextBox tx_teslimalan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}