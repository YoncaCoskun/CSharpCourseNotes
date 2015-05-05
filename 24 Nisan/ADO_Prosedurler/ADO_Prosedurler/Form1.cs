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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("UrunVerStokIle", "server=.;database=northwind;integrated security=sspi;");


            adapter.SelectCommand.Parameters.AddWithValue("@miktar",20);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure; //kendisinin stroe proc oldugunu bılıyor

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            listBox1.DataSource = datatable;
            listBox1.DisplayMember = "ProductName";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi;");

            SqlCommand command = new SqlCommand("select * from SilinmeyenPersonelTablosu", connect);

            DataTable datatable = new DataTable();

            connect.Open();
            SqlDataReader rdr = command.ExecuteReader();
            datatable.Load(rdr);
            connect.Close();

            listBox2.DataSource = datatable;
            listBox2.DisplayMember = "FirstName";
        }
    }
}
