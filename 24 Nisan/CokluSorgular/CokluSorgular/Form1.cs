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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bir reader kapatılmadan baska bır reader daha calıstırabılme durumu-->MARS tır
        string connectStringi = "server=.;database=northwind;integrated security=sspi;MultipleActiveResultSets=true";
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection(connectStringi);
            SqlCommand cmbCalisan = new SqlCommand("select* from Employees",connect);
            SqlCommand cmbMusteri = new SqlCommand("select* from Customers",connect);

            connect.Open();

            SqlDataReader rdr1 = cmbCalisan.ExecuteReader();

            while (rdr1.Read())
            {
                listBox1.Items.Add(rdr1["FirstName"]+""+rdr1["LastName"]);
            }

            SqlDataReader rdr2 = cmbMusteri.ExecuteReader();

            while (rdr2.Read())
            {
                listBox2.Items.Add(rdr2["CompanyName"]);
            }
            connect.Close();

        }
    }
}
