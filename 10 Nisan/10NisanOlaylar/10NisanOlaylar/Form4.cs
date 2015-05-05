using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10NisanOlaylar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] doktorlar = new string[0];  //doktorlar dizisi olusturuldu
        private void Form4_Load(object sender, EventArgs e)
        {
            //acılır acılmaz brans ta secınız gorulsun
            cmbDoktorBrans.SelectedIndex = 0;
            cmbPoliklinik.SelectedIndex = 0;
        }

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {

            if (btnDoktorKaydet.Text == "Kaydet")
            {
                Array.Resize(ref doktorlar, doktorlar.Length + 1);  //diziyi her ekleme yapıldıgında bır arttırmak
                string kayit = txtDoktorAdi.Text + ";" + txtDoktorSoyadi.Text + ";" + cmbDoktorBrans.SelectedItem;  //; birleştirme yapar
                doktorlar[doktorlar.Length - 1] = kayit;  //aldıgımız kaydı doktorlar dızısıne ekledık
                lstDoktorlar.Items.Add(txtDoktorAdi.Text + " " + txtDoktorSoyadi.Text);
            }
            else
            {
                string kayit = txtDoktorAdi.Text + ";" + txtDoktorSoyadi.Text + ";" + cmbDoktorBrans.SelectedItem;
                doktorlar[seciliIndex] = kayit;
                lstDoktorlar.Items[seciliIndex] = txtDoktorAdi.Text + " " + txtDoktorSoyadi.Text;
                btnDoktorKaydet.Text = "Kaydet";
            }

            txtDoktorAdi.Text = "";  //yada txtDoktorAdi.Clear(); yapılabilir
            txtDoktorSoyadi.Text = "";
            cmbDoktorBrans.SelectedIndex = 0;

        }
        int seciliIndex;
        private void lstDoktorlar_DoubleClick(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedIndex > -1)  //ListBox bos deıl ıken yapılabılır
            {
                //ad;soyad;brans
                //double click yapıldıgında bılşgıler gerı gelsın kutucuklara
                seciliIndex = lstDoktorlar.SelectedIndex;
                string[] doktor = doktorlar[lstDoktorlar.SelectedIndex].Split(';');
                txtDoktorAdi.Text = doktor[0];
                txtDoktorSoyadi.Text = doktor[1];
                cmbDoktorBrans.SelectedItem = doktor[2];
                btnDoktorKaydet.Text = "Güncelle";
            }
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedIndex > 0)
            {
                string seciliPoliklinik = cmbPoliklinik.SelectedItem.ToString();
                lstDoktorSec.Items.Clear();
                foreach (string doktor in doktorlar)
                {
                    string[] bilgiler = doktor.Split(';');
                    if (seciliPoliklinik==bilgiler[2])
                    {
                        lstDoktorSec.Items.Add(bilgiler[0]+" "+bilgiler[1]);
                    }
                }
            }
        }

      
        




    }
}
