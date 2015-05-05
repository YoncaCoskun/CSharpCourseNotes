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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //program acılır acılmaz butun urunler gorulsun

            SqlConnection connect = new SqlConnection("server=PC;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand("select ProductName from Products",connect);


            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()==true)
            {
                checkedListBox1.Items.Add(reader.GetString(0));
            }

            connect.Close();


        }

        SqlConnection connect = new SqlConnection("server=PC;database=northwind;integrated security=sspi");
        private void button1_Click(object sender, EventArgs e)
        {
            string seciliOlanlar = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                seciliOlanlar += "'"+item+"'"+",";
            }
            seciliOlanlar = seciliOlanlar.Remove(seciliOlanlar.Length-1);

            string komut = "select OD.OrderID from Products p join [Order Details] od on p.ProductID=OD.ProductID WHERE p.ProductName in("+seciliOlanlar+")";

            listBox1.Items.Clear();
            SqlCommand command = new SqlCommand(komut,connect);
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetInt32(0));
            }

            connect.Close();
        }
    }
}
