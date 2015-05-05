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

namespace ADOdisconnected
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // disconnected sekilde calısanlar tablosunu datagridview in datasource una aktarınız.

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees","server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            dataGridView1.DataSource = datatable;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
