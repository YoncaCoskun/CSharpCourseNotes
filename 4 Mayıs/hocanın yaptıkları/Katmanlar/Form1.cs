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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Urun guncellenecek = null;
        private void button1_Click(object sender, EventArgs e)
        {
            // ürün adı
            // ürün id
            // birim Fiyati
            // stok miktarı
            listBox1.Items.AddRange(Urun.urunleriVer().ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun u;
            bool guncellemeMi = false;
            if (guncellenecek == null)
            {
                u = new Urun();
            }
            else
            {
                u = guncellenecek;
                guncellemeMi = true;
            }
            u.UrunAdi = textBox1.Text;
            u.BirimFiyat = Convert.ToDouble(textBox2.Text);
            u.StokMiktari = Convert.ToInt32(textBox3.Text);

            bool islemTamamMi = guncellemeMi ? u.Guncelle() : u.Kaydet();

            if (islemTamamMi)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Urun.urunleriVer().ToArray());
                guncellenecek = null;
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Urun u = listBox1.SelectedItem as Urun;
            textBox1.Text = u.UrunAdi;
            textBox2.Text = u.BirimFiyat.ToString();
            textBox3.Text = u.StokMiktari.ToString();
            guncellenecek = u;
        }
    }
}
