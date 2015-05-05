using OkulLibrary;
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
    public partial class frmVeliKayit : Form
    {
        public frmVeliKayit()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Veli v = new Veli();
            v.VeliAdi = txtVeliAdi.Text;
            v.VeliSoyadi = txtVeliSoyadi.Text;
            v.TelefonNo = txtTelefon.Text;

            this.Tag = v;   //kullanıcının gormesını ıstemedgımız ama ram de tutmak ıstedıgımız seyleri burda saklıyoruz.bu formun tag ına veliyi aktarıyoruz.
            this.Close();  //kaydetme isleminden sonra o formu kapatabılmek ıcın yaptık
        }

        private void frmVeliKayit_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                Veli guncellenecek = (Veli)this.Tag;
                btnKaydet.Text = "Güncelle";
                txtVeliAdi.Text = guncellenecek.VeliAdi;
                txtVeliSoyadi.Text = guncellenecek.VeliSoyadi;
                txtTelefon.Text = guncellenecek.TelefonNo;
            }
        }

        
    }
}
