using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitUygulama
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            frmCalisanlar frm=new frmCalisanlar();
            frm.Show();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            frmKategoriler frm=new frmKategoriler();
            frm.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler frm=new frmUrunler();
            frm.Show();
        }
    }
}
