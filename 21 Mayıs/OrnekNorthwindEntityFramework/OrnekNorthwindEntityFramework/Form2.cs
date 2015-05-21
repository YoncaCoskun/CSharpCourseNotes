using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrnekNorthwindEntityFramework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           NorthwindEntities context = new NorthwindEntities();         
           Category category=new Category();
            category.CategoryName = "Domates";
            category.Description = "Tatlı,kırmızı domatesler";

            context.Categories.Add(category);
            context.SaveChanges();  //yapılan tum degısıklıklerı ılıskılendırılmıs database e gonderır.
            MessageBox.Show("kaydedildi");





        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            NorthwindEntities context=new NorthwindEntities();

            //List<Category> kategori= context.Categories.Where(x => x.CategoryID == 3).ToList();
            //Category kat=kategori.FirstOrDefault();  bu sekilde guncellestırme yapılabılır fakat cok tercıh edılmıyor.

           Category kat=context.Categories.FirstOrDefault(x => x.CategoryID == 3); //kategori id si 3 olanlardan ilkini al.

            if (kat != null)
            {
                kat.CategoryName = "Sebze";
                context.SaveChanges();
                MessageBox.Show("guncellendi");
            }

            
        }
    }
}
