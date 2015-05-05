using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesetHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Doktor[] doktorlar=new Doktor[0];
        List<Doktor> doktorlar = new List<Doktor>();
        List<Hasta> hastalar = new List<Hasta>();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBrans.SelectedIndex = 0;
            cmbPoliklinik.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (btnKaydet.Text=="Kaydet")
            {
                Doktor yeniDoktor = new Doktor();

                yeniDoktor.DoktorAdi = txtDoktorAdi.Text;
                yeniDoktor.DoktorSoyadi = txtDoktorSoyadi.Text;
                yeniDoktor.Brans = cmbBrans.SelectedItem.ToString();

                doktorlar.Add(yeniDoktor);  //diziye ekledik

                lstDoktorlar.Items.Add(yeniDoktor.kendiniTanit());
                cmbDoktorlar.Items.Add(yeniDoktor.kendiniTanit());
            }
            else
            {
                Doktor guncellenecek=doktorlar[doktorIndex];

                guncellenecek.DoktorAdi = txtDoktorAdi.Text;
                guncellenecek.DoktorSoyadi = txtDoktorSoyadi.Text;
                guncellenecek.Brans = cmbBrans.SelectedItem.ToString();

                lstDoktorlar.Items[doktorIndex] = guncellenecek.kendiniTanit();
                cmbDoktorlar.Items[doktorIndex] = guncellenecek.kendiniTanit();

                btnKaydet.Text = "Kaydet";
            }



            txtDoktorAdi.Clear();
            txtDoktorSoyadi.Clear();
            cmbBrans.SelectedIndex = 0;


        }

        int doktorIndex;
        private void lstDoktorlar_DoubleClick(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedIndex > -1)
            {
                doktorIndex = lstDoktorlar.SelectedIndex;
                Doktor guncellenecek = doktorlar[doktorIndex];

                txtDoktorAdi.Text = guncellenecek.DoktorAdi;
                txtDoktorSoyadi.Text = guncellenecek.DoktorSoyadi;
                cmbBrans.SelectedItem = guncellenecek.Brans;

                btnKaydet.Text = "Güncelle";
                
            }
        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            Hasta yeniHasta = new Hasta();

            if (btnHastaKaydet.Text == "Kaydet")
            {
               // yeniHasta.Ilaclar=new List<string>();  //bu sekıldede new yaparak dırek ekleyebılırız

                yeniHasta.HastaAdi = txtHastaAdi.Text;
                yeniHasta.HastaSoyadi = txtHastaSoyadi.Text;
                yeniHasta.DogumTarihi = dtpDogumTarihi.Value;
                yeniHasta.TelefonNo = txtTelefonNo.Text;
                yeniHasta.Poliklinik = cmbPoliklinik.SelectedItem.ToString();
                yeniHasta.Doktoru = clbDoktorlar.CheckedItems[0].ToString();


                hastalar.Add(yeniHasta);

                lstHastalar.Items.Add(yeniHasta.KendiniTanit());
            }
            else
            {
                btnHastaKaydet.Text = "Kaydet";
                Hasta guncellenecek = hastalar[hastaIndex];

                guncellenecek.HastaAdi = txtHastaAdi.Text;
                guncellenecek.HastaSoyadi = txtHastaSoyadi.Text;
                guncellenecek.DogumTarihi = dtpDogumTarihi.Value;
                guncellenecek.TelefonNo = txtTelefonNo.Text;
                guncellenecek.Poliklinik = cmbPoliklinik.SelectedItem.ToString();
                guncellenecek.Doktoru = clbDoktorlar.CheckedItems[0].ToString();

                lstHastalar.Items[hastaIndex] = guncellenecek.KendiniTanit();
                
            }



            txtHastaAdi.Clear();
            txtHastaSoyadi.Clear();
            cmbPoliklinik.SelectedIndex = 0;
        }


        int hastaIndex;
        private void lstHastalar_DoubleClick(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedIndex > -1)
            {
                hastaIndex = lstHastalar.SelectedIndex;
                Hasta guncellenecek = hastalar[hastaIndex];

                txtHastaAdi.Text = guncellenecek.HastaAdi;
                txtHastaSoyadi.Text = guncellenecek.HastaSoyadi;
                dtpDogumTarihi.Value = guncellenecek.DogumTarihi;
                txtTelefonNo.Text = guncellenecek.TelefonNo;
                cmbPoliklinik.SelectedItem = guncellenecek.Poliklinik;

                int index = clbDoktorlar.Items.IndexOf(guncellenecek.Doktoru);
                clbDoktorlar.SetItemChecked(index,true);

                btnHastaKaydet.Text = "Güncelle";

            }
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbDoktorlar.Items.Clear();
            

            if (cmbPoliklinik.SelectedIndex > -1)
            {
                string seciliPoliklinik = cmbPoliklinik.SelectedItem.ToString();

                foreach (Doktor doktor in doktorlar)
                {
                    
                    if ( seciliPoliklinik== doktor.Brans)
                    {
                        clbDoktorlar.Items.Add(doktor.kendiniTanit());
                    }
                }
            }


        }

        private void clbDoktorlar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbDoktorlar.CheckedItems.Count > 0)
            {                
                    clbDoktorlar.SetItemChecked(clbDoktorlar.CheckedIndices[0], false);
                
            }
        }

        private void btnIlacKaydet_Click(object sender, EventArgs e)
        {
            if (lstDoktorHastalari.SelectedIndex > -1)
            {
                foreach (Hasta hasta in hastalar)
                {
                   
                    if (hasta.KendiniTanit()==lstDoktorHastalari.SelectedItems.ToString())
                    {
                        foreach (object item in clbIlaclar.CheckedItems)
                        {
                            hasta.Ilaclar.Add(item.ToString());
                        }
                    }
                }
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoktorHastalari.Items.Clear();

            foreach (Hasta hasta in hastalar)
            {
                if (hasta.Doktoru==cmbDoktorlar.SelectedItem.ToString())
                {

                    lstDoktorHastalari.Items.Add(hasta.KendiniTanit());

                }
            }
        }

        private void btnDenemeler_Click(object sender, EventArgs e)
        {
            Kedi k = new Kedi();

            k.KediAdi = "Yumak";  

            MessageBox.Show(k.KediAdi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti b = new Baglanti("http");
            b.baglan();
        }



     
        

       

        
      
}
}
