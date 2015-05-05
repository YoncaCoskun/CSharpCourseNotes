using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluSorgular
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //iki listbox disconnect ile doldurmak(iki select sorgusunu tek bıyerde sırayla calıstırarak)
            //----------coklu select sorgularında disconnected durumu-------------------


            SqlDataAdapter adapter = new SqlDataAdapter("select e.*,FirstName+' '+LastName isim from Employees e;select*from Customers","server=.;database=northwind;integrated security=sspi;");

            DataSet tabloListesi = new DataSet();  //coklu sorguya cozum(icerisinde bırden fazla tablo bulunduruyor)
            adapter.Fill(tabloListesi);

            listBox1.DataSource=tabloListesi.Tables[0];
            listBox1.DisplayMember = "isim";

            listBox2.DataSource = tabloListesi.Tables[1];
            listBox2.DisplayMember = "CompanyName";
       



        }

     
    }
}
