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
    public partial class frmVeliler : Form
    {
        public frmVeliler()
        {
            InitializeComponent();
        }

        private void frmVeliler_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmVeliKayit frm = new frmVeliKayit();
            frm.ShowDialog();  //yeni form acıldıgında arkaplandakı formlara tıklayamıyor
            if (frm.Tag!=null)
            {
                Veli v = (Veli)frm.Tag;
                v.VeliId = Tanimlar.Veliler.Count;  //herbır velıye oto numara vercek
                Tanimlar.Veliler.Add(v); //VELİ OLARAK tipini belirledik.
                Doldur();
            }
        }

        private void Doldur()
        {
            lstVeliler.Items.Clear();
            foreach (Veli veli in Tanimlar.Veliler)
            {
                lstVeliler.Items.Add(veli);
            }
        }

        private void lstVeliler_DoubleClick(object sender, EventArgs e)
        {
            
            if (lstVeliler.SelectedIndex>-1)
            {
                Veli v=lstVeliler.SelectedItem as Veli;
                frmVeliKayit frm = new frmVeliKayit();
                frm.Tag = v;
                frm.ShowDialog(); //tag ıcındekı velı bılgısını tekrar eskı yerlerıne aktardık guncellemek yapmak ıcın
                v = frm.Tag as Veli; //yenı gelen guncellemeyi alır
                Tanimlar.Veliler[v.VeliId] = v;

                Doldur();
            }
        }
    }
}
