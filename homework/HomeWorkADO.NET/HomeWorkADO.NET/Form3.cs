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

namespace HomeWorkADO.NET
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //form load oldugu zaman calısanların adı ve soyadı listbox1 e disconnected sekılde gelsın


            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees", "server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            datatable.Columns.Add("FullName", typeof(string), "FirstName+' '+LastName");



            listBox1.DataSource = datatable;
            listBox1.DisplayMember = "FullName";
            listBox1.ValueMember = "EmployeeID";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bu butona tıklayınca calısana aıt sıparısler disconnected olarak listbox2 ye aktarılcak

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Orders where EmployeeID=@id", "server=.;database=northwind;integrated security=sspi");

            adapter.SelectCommand.Parameters.AddWithValue("@id", listBox1.SelectedValue);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            listBox2.DataSource = dt;
            listBox2.DisplayMember = "OrderID";
            listBox2.ValueMember = "OrderID";

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //bu butona tıklayınca secılen sıparıse aıt urun adları disconnected ile listelenecek(listbox3 te)

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Order Details] od join Products p on p.ProductID=od.ProductID where OrderID=@id", "server=.;database=northwind;integrated security=sspi");

            adapter.SelectCommand.Parameters.AddWithValue("@id", listBox2.SelectedValue);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            listBox3.DataSource = dt;
            listBox3.DisplayMember = "ProductName";


        }


    }
}
