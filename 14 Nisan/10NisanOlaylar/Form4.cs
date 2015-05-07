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
                cmbDoktorlar.Items.Add(txtDoktorAdi.Text + " " + txtDoktorSoyadi.Text);
            }
            else
            {
                string kayit = txtDoktorAdi.Text + ";" + txtDoktorSoyadi.Text + ";" + cmbDoktorBrans.SelectedItem;
                doktorlar[seciliIndex] = kayit;
                lstDoktorlar.Items[seciliIndex] = txtDoktorAdi.Text + " " + txtDoktorSoyadi.Text;

                cmbDoktorlar.Items[seciliIndex] = txtDoktorAdi.Text + " " + txtDoktorSoyadi.Text;
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
            lstDoktorSec.Items.Clear();
            if (cmbPoliklinik.SelectedIndex > 0)
            {
                string seciliPoliklinik = cmbPoliklinik.SelectedItem.ToString();

                foreach (string doktor in doktorlar)
                {
                    string[] bilgiler = doktor.Split(';');
                    if (seciliPoliklinik == bilgiler[2])
                    {
                        lstDoktorSec.Items.Add(bilgiler[0] + " " + bilgiler[1]);
                    }
                }
            }
        }


        List<string> hastalar = new List<string>();  // string[] doktorlar = new string[0]; aynı ifadedir
        Random rnd = new Random();
        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            string kayit = txtHastaAdi.Text + ";" + txtHastaSoyadi.Text + ";" + txtTelefonNo.Text + ";" + dtpDogumTarihi.Value.ToShortDateString() + ";" + cmbPoliklinik.SelectedItem + ";";

            //Hasta veri=null; // null degeri atamazsak pointer olarak goruluyor ve hata veriyor
            Hasta veri=new Hasta();  //hasta nesnesine ramde yer açar ona uygun  (hasta constructor metodudur(user defined type))
            veri.hastaAdi = "hasan";
            int sayi = 5;  // sadece stack te yer alır bunlara value type denir.Hem stack hemde heap te bulunan turlere referans type denir.new diye cogaltılan herseye reference type dıyebılırız.

            //reference type:kullanıcı tanımlı tıpler reeference type diye gecer.null degerini kabul ederler.reference type lar new anahtarı ıle cogaltılıyorlar.
            //random
            //Math
            //object
            //string
            //udt(user define type)

            //value type: sadece stack kısmında yer alır
            //int
            //long
            //char
            //bool


            if (lstDoktorSec.CheckedItems.Count > 0)
            {
                kayit += lstDoktorSec.CheckedItems[0];

            }
            else
            {
                int index = rnd.Next(lstDoktorSec.Items.Count);
                kayit += lstDoktorSec.Items[index];
            }

            if (btnHastaKaydet.Text == "Kaydet")
            {
                hastalar.Add(kayit);  //diziye ekleme
                lstHastalar.Items.Add(txtHastaAdi.Text + " " + txtHastaSoyadi.Text);

            }
            else
            {
                hastalar[seciliHastaIndex] = kayit;
                lstHastalar.Items[seciliHastaIndex] = txtHastaAdi.Text + " " + txtHastaSoyadi.Text;
                btnHastaKaydet.Text = "Kaydet";
                btnHastaKaydet.ImageIndex = 1;
            }


            txtHastaAdi.Text = "";
            txtHastaSoyadi.Clear();
            txtTelefonNo.ResetText();
            dtpDogumTarihi.Value = DateTime.Now;
            cmbPoliklinik.SelectedIndex = 0;


        }

    
        private void lstDoktorSec_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && lstDoktorSec.CheckedItems.Count > 0)
            {

                for (int i = 0; i < lstDoktorSec.Items.Count; i++)
                {
                    lstDoktorSec.SetItemChecked(i, false);

                }
            }
        }
        int seciliHastaIndex;
        private void lstHastalar_DoubleClick(object sender, EventArgs e)
        {
            seciliHastaIndex = lstDoktorlar.SelectedIndex;
            string[] hasta = hastalar[lstHastalar.SelectedIndex].Split(';');
            txtHastaAdi.Text = hasta[0];
            txtHastaSoyadi.Text = hasta[1];
            txtTelefonNo.Text = hasta[2];
            dtpDogumTarihi.Value = Convert.ToDateTime(hasta[3]);
            cmbPoliklinik.SelectedItem = hasta[4];

            int index = lstDoktorSec.Items.IndexOf(hasta[5]);
            lstDoktorSec.SetItemChecked(index, true);

            btnHastaKaydet.ImageIndex = 0;
            btnHastaKaydet.Text = "Güncelle";

        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoktorHastalari.Items.Clear();

            if (cmbDoktorlar.SelectedIndex > -1)
            {
                foreach (string hastaBilgi in hastalar)
                {
                    string[] hasta = hastaBilgi.Split(';');

                    if (hasta[5]==cmbDoktorlar.SelectedItem.ToString())
                    {
                        lstDoktorHastalari.Items.Add(hasta[0]+" "+hasta[1]);
                    }
                }
            }
        }

        private void lstDoktorHastalari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorHastalari.SelectedIndex > -1)
            {
                foreach (string hastaBilgi in hastalar)
                {
                    string[] hasta = hastaBilgi.Split(';');
                    if (hasta[0]+" "+hasta[1]==lstDoktorHastalari.SelectedItem.ToString())
                    {
                        lblHastaAdi.Text=hasta[0];
                        lblHastaSoyadi.Text=hasta[1];
                        lblCepTelefonu.Text=hasta[2];
                        lblDogumTarihi.Text=hasta[3];
                        lblPoliklinik.Text=hasta[4];

                    }
                }
            }
        }







    }
}
