using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NortheEntityLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chai urununun satıldıgı yerler nerelere gıtmıs?(linq kullanarak yapmak)
        }
        NorthwindLinqDataContext data = new NorthwindLinqDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = from siparis in data.Orders
                        join satisDetay in data.Order_Details on
                        siparis.OrderID equals satisDetay.OrderID
                        join urun in data.Products on
                        satisDetay.ProductID equals urun.ProductID
                        where urun.ProductName.Equals("Chai")
                        select new
                        {
                            siparis.CustomerID,
                            siparis.OrderID,
                            satisDetay.Quantity,
                            satisDetay.UnitPrice,
                            siparisTarihi = siparis.OrderDate

                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        //---------------------------------------------------------------------------------------------------------


        NorthwindEntities entity = new NorthwindEntities();//(ModelFirst kullanarak yapmak)
        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = from siparisDetay in entity.Order_Details
                        where siparisDetay.Products.ProductName.Equals("Chai")
                        select new
                        {
                            siparisDetay.Orders.Customers.CompanyName,
                            siparisDetay.Orders.Employees.FirstName,
                            siparisDetay.Orders.Employees.LastName,
                            siparisDetay.Orders.OrderID,
                            siparisDetay.Quantity,
                            siparisDetay.UnitPrice


                        };
            dataGridView1.DataSource = sonuc.ToList();
                      
        }
    }
}
