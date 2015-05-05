using DbAccess;
using NorthwindBLL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB.connectStringi=ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductEntity entity = new ProductEntity();
                entity.ProductName = txtUrunAdi.Text;
                entity.UnitPrice = Convert.ToDouble(txtBirimFiyati.Text);
                entity.UnitsInStock = Convert.ToInt32(txtStokMiktari.Text);

                new ProductBll().kaydet(entity);
                doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        private void doldur()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new ProductBll().urunleriVer().ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.connectStringi = "server=.;database=northwind;integrated security=sspi;";
            doldur();
            
        }
    }
}
