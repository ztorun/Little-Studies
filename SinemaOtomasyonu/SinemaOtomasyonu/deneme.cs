using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wordeaktar = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace SinemaOtomasyonu
{
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }

        private void btn_yaz_Click(object sender, EventArgs e)
        {
            Wordeaktar.Application wordapp = new Wordeaktar.Application();
            wordapp.Visible = true;
            Wordeaktar.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref wordobj);
            wordapp.Selection.TypeText(tx_teslimalan.Text);
        }
    }
}
