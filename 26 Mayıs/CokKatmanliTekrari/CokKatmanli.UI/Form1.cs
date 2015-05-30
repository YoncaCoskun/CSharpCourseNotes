using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CokKatmanli.BLL;
using CokKatmanli.Entity;

namespace CokKatmanli.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product urun=new Product();
            urun.ProductName = txtAd.Text;
            urun.UnitPrice = nudFiyat.Value;
            urun.UnitsInStock = Convert.ToInt32(nudStok.Value);

            ProductBLL bll=new ProductBLL();
            bll.UrunEkle(urun);
       
        }
    }
}
