using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cokKatmanli.BLL;
using cokKatmanli.Entity;

namespace cokKatmanli.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriBLL bll = new KategoriBLL();

            Category kategori = bll.KategoriGetir(Convert.ToInt32(textBox1.Text));

            string sonuc = string.Format("Ad:{0} Aciklama:{1}", kategori.KategoriName, kategori.Description);

            MessageBox.Show(sonuc);

        }
    }
}
