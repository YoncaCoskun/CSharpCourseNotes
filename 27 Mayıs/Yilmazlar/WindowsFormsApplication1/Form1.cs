using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yilmazlar.Business;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerBusiness customerBusiness = new CustomerBusiness()  ;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerBusiness.GetAll();

        }
    }
}
