using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmBilgeAnaokuluUygulama : Form
    {
        public frmBilgeAnaokuluUygulama()
        {
            InitializeComponent();
        }

        private void calisanGirisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCalisanGiris frm = new frmCalisanGiris();
            frm.ShowDialog();
        }

        private void ogrenciKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frm = new frmOgrenciGiris();
            frm.ShowDialog();
        }

      
      

     
    }
}
