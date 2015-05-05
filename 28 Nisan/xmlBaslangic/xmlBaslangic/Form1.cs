using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlBaslangic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {

            ds.ReadXml("http://www.tcmb.gov.tr/kurlar/today.xml");

            DataTable dtKurlar = ds.Tables["Currency"];
            listBox1.DataSource = dtKurlar;
            listBox1.DisplayMember = "Isim";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow satir = (listBox1.DataSource as DataTable).Rows[listBox1.SelectedIndex];
            lblAlisFiyati.Text=satir["ForexSelling"].ToString();
            lblSatisFiyati.Text = satir["ForexBuying"].ToString();

        }
    }
}
