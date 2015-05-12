using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------DBFirst ----------------------------------------------
        NorthwindEntities entity = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
          var sonuc=  entity.Employees.Where(calisan => calisan.Notes.Contains("toast")).Select(x=>x.FirstName+" "+x.LastName);  //where kosuluyla select sorgusu cektik.

            listBox1.Items.AddRange(sonuc.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = (entity.Categories.Where(categori => categori.CategoryName.Equals("Beverages")).Single().CategoryID);

            //startwith ve andwith olması ıcın sunlat ıle baslayan derken kullanırız contaıns yerıne.

        var urunler=entity.Products.Where(x => x.CategoryID==sayi).Select(y=>y.ProductName);  //yapıdan bırtane bısı gelmesı ıcın sıngle dedık.

        listBox1.DataSource = urunler.ToList();  //tolıst yerıne toarray da dıyebılıordık.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //-------------------------------------------LINQ YAZIM SEKLI YANİ BUNA LINQ TO SQL DENIYOR.----------------------
            //language integrated query(dil entegreli sorgulama yani bir dil ile heryere sorgu çekme-->linq)
            //select sorgusunu ıcerısıne bu sekılde veririz.(bizim burda yaptıgımız LINQ TO SQL dir.)

            //linq alternatifleri--> LINK TO XML,LINK TO OBJECT

            //select*from Orders bu tabloya select cekecegız.

            var sonuc = from siparis in entity.Orders
                        where siparis.CustomerID.Equals("ALFKI")
                        select siparis;

            listBox1.DataSource = sonuc.ToList();
            listBox1.DisplayMember = "OrderID";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var sonuc = from siparis in entity.Orders
                        where siparis.CustomerID.Equals("ALFKI")
                        select new {
                            SiparisId = siparis.OrderID ,
                            SiparisTarihi=siparis.OrderDate,
                            Ulke=siparis.ShipCountry
                        }; //suan burda yenı bır tıp olusturduk.(dinamik type olusturduk.)
            dataGridView1.DataSource = sonuc.ToList();
        }

      
    }
}
