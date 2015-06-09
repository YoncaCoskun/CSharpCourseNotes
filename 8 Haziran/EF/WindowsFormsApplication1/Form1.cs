using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities context = new NorthwindEntities();

            var urunler = context.Products.AsQueryable();

            if (txtFiyat.Text.Length > 0)
            {
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                urunler = urunler.Where(x => x.UnitPrice > fiyat);
            }
            if (txtStok.Text.Length > 0)
            {
                short stok = Convert.ToInt16(txtFiyat.Text);
                urunler = urunler.Where(x => x.UnitsInStock < stok);
            }

            dataGridView1.DataSource = urunler.ToArray();
        }
    }
}
