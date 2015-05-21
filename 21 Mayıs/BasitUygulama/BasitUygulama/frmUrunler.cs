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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        NorthwindEntities context=new NorthwindEntities();

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunGoster();
        }

        void UrunGoster()
        {
            listView1.Items.Clear();
            var urunler = context.Products;

            foreach (Product product in urunler)
            {
                ListViewItem item = new ListViewItem();
                item.Text = product.ProductID.ToString();
                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.SupplierID.ToString());
                item.SubItems.Add(product.CategoryID.ToString());
                item.SubItems.Add(product.QuantityPerUnit);
                item.SubItems.Add(product.UnitPrice.ToString());
                item.SubItems.Add(product.UnitsInStock.ToString());
                item.SubItems.Add(product.UnitsOnOrder.ToString());
                item.SubItems.Add(product.ReorderLevel.ToString());
                item.SubItems.Add(product.Discontinued.ToString());

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelProductId.Text.Length > 0)
            {
                int id = Convert.ToInt32(labelProductId.Text);
                Product guncellenecekProduct = context.Products.FirstOrDefault(x => x.ProductID == id);
                if (guncellenecekProduct != null)
                {
                    guncellenecekProduct.ProductName = IlkHarfiBuyut(txtProductName.Text.Trim());
                    guncellenecekProduct.QuantityPerUnit = IlkHarfiBuyut(txtQuantityPerUnit.Text.Trim());
                    guncellenecekProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                    guncellenecekProduct.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
                    guncellenecekProduct.UnitsOnOrder = Convert.ToInt16(txtUnitsInOrder.Text);
                    guncellenecekProduct.ReorderLevel = Convert.ToInt16(txtReorderLevel.Text);
                    guncellenecekProduct.Discontinued = Convert.ToBoolean(txtDiscontinued.Text);

                }
                context.SaveChanges();

                Temizle();
                UrunGoster();
                MessageBox.Show("Güncelleme Başarılı");


            }
            else
            {
                Product NewProduct = new Product();


                NewProduct.ProductName = txtProductName.Text.Trim();
                NewProduct.QuantityPerUnit = txtQuantityPerUnit.Text.Trim();
                NewProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                NewProduct.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
                NewProduct.UnitsOnOrder = Convert.ToInt16(txtUnitsInOrder.Text);
                NewProduct.ReorderLevel = Convert.ToInt16(txtReorderLevel.Text);
                NewProduct.Discontinued = Convert.ToBoolean(txtDiscontinued.Text);

                context.Products.Add(NewProduct);
                context.SaveChanges();

                UrunGoster();
                MessageBox.Show("Kayıt Başarılı");
            }


        }

        private void Temizle()
        {
            labelProductId.Text = "";
            labelCategoryId.Text = "";
            labelSupplierId.Text = "";
            txtProductName.Clear();
            txtDiscontinued.Clear();
            txtQuantityPerUnit.Clear();
            txtReorderLevel.Clear();
            txtUnitPrice.Clear();
            txtUnitsInOrder.Clear();
            txtUnitsInStock.Clear();
        }
        private string IlkHarfiBuyut(string deger)
        {
            string ilkHarf = deger.Substring(0, 1);
            string kalani = deger.Substring(1);

            return ilkHarf.ToUpper() + kalani.ToLower();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem seciliItem = listView1.FocusedItem;

            labelProductId.Text = seciliItem.Text;
            txtProductName.Text = seciliItem.SubItems[1].Text;
            labelSupplierId.Text = seciliItem.SubItems[2].Text;
            labelCategoryId.Text = seciliItem.SubItems[3].Text;
            txtQuantityPerUnit.Text = seciliItem.SubItems[4].Text;
            txtUnitPrice.Text = seciliItem.SubItems[5].Text;
            txtUnitsInStock.Text = seciliItem.SubItems[6].Text;
            txtUnitsInOrder.Text = seciliItem.SubItems[7].Text;
            txtReorderLevel.Text = seciliItem.SubItems[8].Text;
            txtDiscontinued.Text = seciliItem.SubItems[9].Text;

        }
    }
}
