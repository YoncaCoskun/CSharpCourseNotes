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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons butonlar=MessageBoxButtons.YesNoCancel;
            DialogResult sonuc = MessageBox.Show("Tammam mı", "Baslık", butonlar, MessageBoxIcon.Warning);


            Yonler y = Yonler.Yukari; // bu sekılde getırebılırız.5 degeri verdıgımız ıcın 5 gosterır

            object obje = 12;
            int sayi=(int)obje;

            sayi = (int)y;

            // Yonler yy=(Yonler)1;  //bu da bıze sol u verır tersten gidis

            MessageBox.Show(sayi.ToString());
           // MessageBox.Show(sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.MusteriAdi = "Firat";
            s.musteriTuru = MusteriTurleri.ToptanYukluMusteri;
            s.ToplamTutar = 6000;
            s.odemeSekli = OdemeSekilleri.Nakit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (OdemeSekilleri odemeSekli in Enum.GetValues(typeof (OdemeSekilleri)))
            {
                comboBox1.Items.Add(odemeSekli);

            }
            foreach (MusteriTurleri musteriTuru in Enum.GetValues(typeof(MusteriTurleri)))
            {
                comboBox2.Items.Add(musteriTuru);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();  

            s.odemeSekli = (OdemeSekilleri)comboBox1.SelectedItem;
            s.musteriTuru=(MusteriTurleri)comboBox2.SelectedItem;

            MessageBox.Show((int)s.odemeSekli+" "+(int)s.musteriTuru);  //veri tabanına gonderırken bu sekilde gonderebiliriz.(daha cok veri tabanı ıcın kullanılıyor)
            //MessageBox.Show(s.odemeSekli + " " + (s.musteriTuru);
        }
    }
}
