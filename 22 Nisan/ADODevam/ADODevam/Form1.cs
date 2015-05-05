using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADODevam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "select FirstName,LastName from Employees";
            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand(komut, connect);



            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetString(0)+" "+reader.GetString(1));
            }

            connect.Close();
        }


    }
}
