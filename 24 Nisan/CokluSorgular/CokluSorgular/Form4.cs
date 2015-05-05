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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers","server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

             DataRow[] satirlar=datatable.Select("CustomerID='ALFKI'");

             DataTable datatableyeni = datatable.Clone();

             foreach (DataRow item in satirlar)
             {
                 datatableyeni.Rows.Add(item.ItemArray);
             }

            listBox1.DataSource = datatableyeni;
            listBox1.DisplayMember = "CompanyName";

        }
    }
}
