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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SirketCagir", "server=.;database=northwind;integrated security=sspi;");
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CompanyName";

            SqlDataAdapter adapter1 = new SqlDataAdapter("UrunGoster", "server=.;database=northwind;integrated security=sspi;");
            adapter1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);

            listBox1.DataSource = dt1;
            listBox1.DisplayMember = "ProductName";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("FiyatGoster", "server=.;database=northwind;integrated security=sspi;");
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@UrunAdi", listBox1.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                listBox2.DataSource = dt;
                listBox2.DisplayMember = "UnitPrice";
                
                                 


            }

        }


        private void button3_Click(object sender, EventArgs e)
        {

            double price = double.Parse(listBox2.Text);
            int count =int.Parse(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text+" "+listBox1.Text+" "+price * count+" $");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select p.ProductName,od.UnitPrice,od.Quantity from [Order Details] od join Products p on p.ProductID=od.ProductID", "server=.;database=northwind;integrated security=sspi;");

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

         
            int toplam = dataGridView1.Rows.Count;
            dataGridView1.Rows[toplam - 2].Cells[0].Value = listBox1.Text;
            dataGridView1.Rows[toplam - 2].Cells[1].Value = listBox2.Text;
            dataGridView1.Rows[toplam - 2].Cells[2].Value = textBox1.Text;

            
            

           

       
        }

       



    }
}
