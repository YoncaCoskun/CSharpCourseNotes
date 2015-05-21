using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitUygulama
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }
        NorthwindEntities context=new NorthwindEntities();

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            KategoriGoster();

        }

        void KategoriGoster()
        {
            listView1.Items.Clear();
            var kategoriler = context.Categories;

            foreach (Category category in kategoriler)
            {
                ListViewItem item = new ListViewItem();
                item.Text =category.CategoryID.ToString();
                item.SubItems.Add(category.CategoryName);
                item.SubItems.Add(category.Description);
                

                listView1.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (labelid.Text.Length > 0) 
            {
                int id = Convert.ToInt32(labelid.Text);
                Category guncellenecekCategory = context.Categories.FirstOrDefault(x => x.CategoryID == id);
                if (guncellenecekCategory != null)
                {
                    guncellenecekCategory.CategoryName = IlkHarfiBuyut(txtCategoryName.Text.Trim());
                    guncellenecekCategory.Description = IlkHarfiBuyut(txtDescription.Text.Trim());
                 
                }
                context.SaveChanges();

                Temizle();
                KategoriGoster();
                MessageBox.Show("Güncelleme Başarılı");


            }
            else
            {
                Category NewCategory = new Category();


                NewCategory.CategoryName = txtCategoryName.Text.Trim();
                NewCategory.Description =txtDescription.Text.Trim();
              

                context.Categories.Add(NewCategory);
                context.SaveChanges();

                KategoriGoster();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

      

        private void Temizle()
        {
            labelid.Text = "";
           txtCategoryName.Clear();
           txtDescription.Clear();
        }
        private string IlkHarfiBuyut(string deger)
        {
            string ilkHarf = deger.Substring(0, 1);
            string kalani = deger.Substring(1);

            return ilkHarf.ToUpper() + kalani.ToLower();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem seciliItem = listView1.FocusedItem;

            labelid.Text = seciliItem.Text;
            txtCategoryName.Text = seciliItem.SubItems[1].Text;
            txtDescription.Text = seciliItem.SubItems[2].Text;
           
        }
       

       
        
        

       






       
    }
}
