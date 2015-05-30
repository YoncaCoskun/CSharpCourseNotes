using System;
using System.Windows.Forms;
using Yilmazlar.Business;
using Yilmazlar.Domain;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BaseBusiness abstract yaptığımız için instance alınamaz.
        //BaseBusiness<Product> prodBusiness = new BaseBusiness<Product>(); 


        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string id = dataGridView1.SelectedRows[0].Cells["ProductId"].Value.ToString();
            string ad = dataGridView1.SelectedRows[0].Cells["ProductName"].Value.ToString();
            string fiyat = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
            string stok = dataGridView1.SelectedRows[0].Cells["Stock"].Value.ToString();

            txtAd.Text = ad;
            numericFiyat.Text = fiyat;
            numericStok.Text = stok;
            labelId.Text = id;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(labelId.Text);

            //Product guncellenecekUrun = prodBusiness.GetById(id);

            //guncellenecekUrun.ProductName = txtAd.Text.Trim();
            //guncellenecekUrun.Price = numericFiyat.Value;
            //guncellenecekUrun.Stock = Convert.ToInt32(numericStok.Value);

            //prodBusiness.Update(guncellenecekUrun);

            //UrunleriGetir();
        }

        void UrunleriGetir()
        {
            //dataGridView1.DataSource = prodBusiness.GetAll();
        }
    }
}
