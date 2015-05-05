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

namespace ADODevam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
  SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

        private void Form3_Load(object sender, EventArgs e)
        {
            string komut = "select OrderId from Orders";

          
            SqlCommand command = new SqlCommand(komut,connect);

            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetSqlInt32(0));

            }

            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string komut = "select ProductName from [Order Details] od JOIN Products p on od.ProductID=p.ProductID where od.OrderID=@id ";

            SqlCommand command = new SqlCommand(komut,connect);
            
            command.Parameters.AddWithValue("@id", listBox1.SelectedItem);
            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox2.Items.Add(reader["ProductName"]);
                }
            }
            connect.Close();

         

        }
    }
}
