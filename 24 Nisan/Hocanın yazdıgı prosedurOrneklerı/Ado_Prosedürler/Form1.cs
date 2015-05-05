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

namespace Ado_Prosedürler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("UrunVerStokIle", "server=.;database=northwind;integrated security=sspi");

            adapter.SelectCommand.Parameters.AddWithValue("@miktar", 20);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "ProductName";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; database=northwind;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select * from Urunler", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            con.Close();

            listBox2.DataSource = dt;
            listBox2.DisplayMember = "ProductName";
        }
    }
}
