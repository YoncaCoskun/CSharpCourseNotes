using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsenkronHatasiCozumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        

            //-------------------------scrollbar sıkıntısını bu sekılde cozduk---------------------------------------

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(doldur);
            Thread t = new Thread(ts);
            t.Start();
        }
        void doldur()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [Order Details]", "server=.;database=northwind;integrated security=sspi;");

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            dataGridView1.Invoke(new gridDoldurDelege(gridDoldur),datatable);

            //dataGridView1.DataSource = datatable;

        }

        delegate void gridDoldurDelege(DataTable datatable);
        public void gridDoldur(DataTable datatable)
        {
            dataGridView1.DataSource = datatable;

        }

    }
}
