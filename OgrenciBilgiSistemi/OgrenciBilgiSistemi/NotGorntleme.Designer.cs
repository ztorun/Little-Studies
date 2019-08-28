namespace OgrenciBilgiSistemi
{
    partial class NotGorntleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGorntleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersvehocalarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yariyilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vize1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vize2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harfliortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAkademikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkademikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(107, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 35);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recep Tayyip Erdoğan Üniversitesi Bilgi Yönetim Sistemi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1169, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yardım";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ogrNoDataGridViewTextBoxColumn,
            this.dersvehocalarDataGridViewTextBoxColumn,
            this.yariyilDataGridViewTextBoxColumn,
            this.vize1DataGridViewTextBoxColumn,
            this.vize2DataGridViewTextBoxColumn,
            this.finalDataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.harfliortalamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAkademikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OgrenciBilgiSistemi.Properties.Resources.a;
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            // 
            // dersvehocalarDataGridViewTextBoxColumn
            // 
            this.dersvehocalarDataGridViewTextBoxColumn.DataPropertyName = "Dersvehocalar";
            this.dersvehocalarDataGridViewTextBoxColumn.HeaderText = "Dersvehocalar";
            this.dersvehocalarDataGridViewTextBoxColumn.Name = "dersvehocalarDataGridViewTextBoxColumn";
            // 
            // yariyilDataGridViewTextBoxColumn
            // 
            this.yariyilDataGridViewTextBoxColumn.DataPropertyName = "Yariyil";
            this.yariyilDataGridViewTextBoxColumn.HeaderText = "Yariyil";
            this.yariyilDataGridViewTextBoxColumn.Name = "yariyilDataGridViewTextBoxColumn";
            // 
            // vize1DataGridViewTextBoxColumn
            // 
            this.vize1DataGridViewTextBoxColumn.DataPropertyName = "Vize1";
            this.vize1DataGridViewTextBoxColumn.HeaderText = "Vize1";
            this.vize1DataGridViewTextBoxColumn.Name = "vize1DataGridViewTextBoxColumn";
            // 
            // vize2DataGridViewTextBoxColumn
            // 
            this.vize2DataGridViewTextBoxColumn.DataPropertyName = "Vize2";
            this.vize2DataGridViewTextBoxColumn.HeaderText = "Vize2";
            this.vize2DataGridViewTextBoxColumn.Name = "vize2DataGridViewTextBoxColumn";
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "Final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "Final";
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // harfliortalamaDataGridViewTextBoxColumn
            // 
            this.harfliortalamaDataGridViewTextBoxColumn.DataPropertyName = "Harfliortalama";
            this.harfliortalamaDataGridViewTextBoxColumn.HeaderText = "Harfliortalama";
            this.harfliortalamaDataGridViewTextBoxColumn.Name = "harfliortalamaDataGridViewTextBoxColumn";
            // 
            // tblAkademikBindingSource
            // 
            this.tblAkademikBindingSource.DataSource = typeof(OgrenciBilgiSistemi.TblAkademik);
            // 
            // NotGorntleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NotGorntleme";
            this.Text = "NotGorntleme";
            this.Load += new System.EventHandler(this.NotGorntleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAkademikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tblAkademikBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersvehocalarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yariyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vize1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vize2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harfliortalamaDataGridViewTextBoxColumn;
    }
}