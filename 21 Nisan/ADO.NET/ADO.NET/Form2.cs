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

namespace ADO.NET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calısanların aslarını listbox a ekleyınız


            
            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand("select FirstName+' '+LastName from Employees",connect); 

            connect.Open();

           SqlDataReader reader = command.ExecuteReader();

           while (reader.Read())
           {
               listBox1.Items.Add(reader.GetString(0));
           }

            connect.Close();
        }
    }
}
