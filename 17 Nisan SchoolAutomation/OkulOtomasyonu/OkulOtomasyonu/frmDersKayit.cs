using OkulLibrary.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class frmDersKayit : Form
    {
        public frmDersKayit()
        {
            InitializeComponent();
        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {

            if (btnDersKayit.Tag == null)
            {
                Ders d = new Ders
                {
                    DersAdi = txtDersAdi.Text,
                    Kredisi = (int)numKredisi.Value,
                    HaftalikSaat = Convert.ToInt32(numSaat.Value)

                };
                Tanimlar.DersLer.Add(d);
            }
            else
            {
                Ders d = btnDersKayit.Tag as Ders;
                d.DersAdi = txtDersAdi.Text;
                d.HaftalikSaat = (int)numSaat.Value;
                d.Kredisi=(int)numKredisi.Value;
                btnDersKayit.Tag = null;
            }

            doldur();

            txtDersAdi.Clear();
            numSaat.Value = 0;
            numKredisi.Value = 0;



        }

        private void frmDersKayit_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            lstDersler.Items.Clear();

            foreach (Ders item in Tanimlar.DersLer)
            {
                lstDersler.Items.Add(item);
            }
        }

        private void lstDersler_DoubleClick(object sender, EventArgs e)
        {
            if (lstDersler.SelectedIndex > -1)
            {
                Ders secilen = lstDersler.SelectedItem as Ders;

                txtDersAdi.Text = secilen.DersAdi;
                numKredisi.Value = secilen.Kredisi;
                numSaat.Value = secilen.HaftalikSaat;
                btnDersKayit.Tag = secilen;  //kullanıcı bundan haberdar degıl

            }
        }
    }
}
