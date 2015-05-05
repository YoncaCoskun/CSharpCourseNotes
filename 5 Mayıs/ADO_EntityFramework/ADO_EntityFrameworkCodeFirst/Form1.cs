using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EntityFrameworkCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GaleriDb data = new GaleriDb();

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(data.arabalar.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();

            araba.Marka = Faker.CompanyFaker.Name();  //fake isimler veriyoruz
            araba.Model = Faker.CompanyFaker.BS();

            data.arabalar.Add(araba);
            data.SaveChanges();
            doldur();

        }

      
    }
}
