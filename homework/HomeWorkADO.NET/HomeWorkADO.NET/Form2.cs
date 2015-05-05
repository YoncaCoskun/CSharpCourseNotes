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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //butna basınca urunler tablosuna disconnected baglantı kurulacak ve urun ısımlerı listbox1 e ,urun fıyatları listbox2 ye aktarılacak
        //pazartesi son gun 23.00

        private void button1_Click(object sender, EventArgs e)
        {
          

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", "server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            listBox1.DataSource = datatable;
            listBox1.DisplayMember = "ProductName";

            listBox2.DataSource = datatable;
            listBox2.DisplayMember = "UnitPrice";
        }
    }
}
