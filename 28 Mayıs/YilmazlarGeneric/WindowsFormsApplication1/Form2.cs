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
using Yilmazlar.Domain;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        CustomerBusiness custBusiness = new CustomerBusiness();
        BaseBusiness<Customer> custBus2 = new BaseBusiness<Customer>(); 

        private void button1_Click(object sender, EventArgs e)
        {
            Customer musteri = custBusiness.SoyadaGoreMusteriGetir(textBox1.Text.Trim());

            if (musteri == null)
            {
                MessageBox.Show("Müşteri Bulunamadı");
            }
            else
            {
                MessageBox.Show(musteri.Firstname);
            }

        }
    }
}
