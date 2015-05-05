using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //urun adı
            //urunıd
            //birimfiyat
            //stokmiktarı

           
            listBox1.Items.AddRange(Urun.urunleriVer().ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Urun urun;

            bool guncellemeMi = false;
            if (button2.Tag==null)
            {
                urun = new Urun();
            }
            else
            {
                urun = button2.Tag as Urun;
                guncellemeMi = true;
            }

      

                urun.UrunAdi = textBox1.Text;
                urun.BirimFiyati = Convert.ToDouble(textBox2.Text);
                urun.StokMiktari = Convert.ToInt32(textBox3.Text);

                bool islemTamamMi = guncellemeMi ? urun.Guncelle() : urun.Kaydet();

                if (islemTamamMi)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(Urun.urunleriVer().ToArray());
                    button2.Tag = null;
                }


            
           

        }

    

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //bu  kısım eksik

        }

   
      
        

       
    }
}
