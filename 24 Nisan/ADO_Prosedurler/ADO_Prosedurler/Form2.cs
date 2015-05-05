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

namespace ADO_Prosedurler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connected sekılde verı tabanına calısan ekleyerek calısanın id sini this.text e yazdırınız

            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi;");

            SqlCommand command = new SqlCommand("CalisanEkle", connect);

             command.Parameters.AddWithValue("@calisanAdi", textBox1.Text);
             command.Parameters.AddWithValue("@calisanSoyadi", textBox2.Text);

             DataTable datatable = new DataTable();

             connect.Open();
             SqlDataReader rdr = command.ExecuteReader();
             datatable.Load(rdr);
             connect.Close();

             
            
          
          

        }
    }
}
