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

namespace ADOdisconnected
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //form load oldugu zaman calısanların adı ve soyadı listbox1 e disconnected sekılde gelsın


            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees", "server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

         
            listBox1.DataSource = datatable;
            listBox1.DisplayMember = "FirstName";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bu butona tıklayınca calısana aıt sıparısler disconnected olarak listbox2 ye aktarılcak
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bu butona tıklayınca secılen sıparıse aıt urun adları disconnected ile listelenecek(listbox3 te)
        }
    }
}
