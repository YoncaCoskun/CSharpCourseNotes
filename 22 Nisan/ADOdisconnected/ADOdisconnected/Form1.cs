using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  //datatable ı kullanmak ıcın mutlaka bunun eklenmıs olması gerekıyor
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOdisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // disconnected nesneleri: SqlDataAdapter,DataTable,DataSet

            DataTable tablo = new DataTable("Veri Tablosu");

            DataColumn kolon1 = new DataColumn("Calisan Adı",typeof(object));  //varsayılan bırakmamalıyız cnku varsayılan bırakılırsa araya strıng falan attıgımızda butun tıplerı aynı yapar buyuzden type of ıle belırtmemız gerekıyor.
            tablo.Columns.Add(kolon1);  // tablomuzda artık kolon var suan eklendı

            tablo.Columns.Add("Calısan Soyadı"); // bu sekıldede kolon eklenebılır

            DataRow satir1 = tablo.NewRow();  //kolonları once ekledıgımız ıcın satır ıcıne kolon syısı kadar ekler
            satir1[0] = "Nancy";
            satir1[1]="Davolio";

            tablo.Rows.Add(satir1);  //artık bu tablonun bır satırı var.



            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Categories","server=.;database=northwind;integrated security=sspi;"); //uzerınde hc verı barındırmaz sadece okuyabılır

            adapter.Fill(tablo);

            //foreach (DataRow item in tablo.Rows)
            //{
            //    listBox1.Items.Add(item[2]);
            //}
            listBox1.DataSource = tablo;
            listBox1.DisplayMember = "CategoryName";  //hangilerini gosterıcegımızı bu sekılde belırlerız.gosterılecek kısım
            listBox1.ValueMember = "CategoryID";  //arkaplanda saklanılan kısım
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear yapmamıza gerek yok cunku datasource aynı gorevıde goruyor yanı datasource her farklı bı secım yapıldıgında refresh yapıyor ve yenı urunler gelıyor.

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products where CategoryID=@id","server=.;database=northwind;integrated security=sspi;");

            adapter.SelectCommand.Parameters.AddWithValue("@id",listBox1.SelectedValue);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            listBox2.DataSource = datatable;
            listBox2.DisplayMember = "ProductName";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

       
        
    }
}
