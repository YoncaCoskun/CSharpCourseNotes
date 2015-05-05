using NorthwindDAL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katmanlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UrunDal data = new UrunDal();
            listBox1.Items.AddRange(data.urunleriVer().ToArray());

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunEntity entity = new UrunEntity();
            entity.UrunAdi =txtUrunAdi.Text;
            entity.StokMiktari = Convert.ToInt32(txtMiktar.Text);
            entity.BirimFiyat = Convert.ToDouble(txtBirimFiyati.Text);

            UrunDal data = new UrunDal();

            bool kayitTamamMi= new UrunDal().Kaydet(entity);
            if (kayitTamamMi)
            {
                txtBirimFiyati.Clear();
                txtMiktar.Clear();
                txtUrunAdi.Clear();

                listBox1.Items.Clear();
                listBox1.Items.AddRange(data.urunleriVer().ToArray());
                


            }

        }
    }
}
