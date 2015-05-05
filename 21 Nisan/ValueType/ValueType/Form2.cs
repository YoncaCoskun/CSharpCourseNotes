using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueType
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Araba[] arabalar=new Araba[5];
        private void button1_Click(object sender, EventArgs e)
        {
            arabalar[2] = new Araba();
            arabalar[2].Markasi = "Audi";
           MessageBox.Show(arabalar[2].Markasi);

        }

        Kitap[] kitaplar=new Kitap[5];
        Kitap k;
        private void button2_Click(object sender, EventArgs e)
        {

            kitaplar[2].KitapAdi = "Arka Sokaklar";
            MessageBox.Show(kitaplar[2].KitapAdi);

            
            k.KitapAdi = "Ezginin gunlugu";
            MessageBox.Show(k.KitapAdi);
        }
    }
}
