using DbAccess;
using NorthwindBLL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanMimari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DB.connectStringi = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryEntity entity = new CategoryEntity();
                entity.CategoryName = textBox1.Text;
                entity.Description = richTextBox1.Text;


                new ProductBll().kategoriKaydet(entity);
                doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void doldur()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new ProductBll().kategoriGoster().ToArray());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DB.connectStringi = "server=.;database=northwind;integrated security=sspi;";
            doldur();
        }

       
    }
}
