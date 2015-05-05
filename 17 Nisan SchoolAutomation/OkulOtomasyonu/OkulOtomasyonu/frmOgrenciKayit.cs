using OkulLibrary;
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
    public partial class frmOgrenciKayit : Form
    {
        public frmOgrenciKayit()
        {
            InitializeComponent();
        }

        private void frmOgrenciKayit_Load(object sender, EventArgs e)
        {
            dersDoldur();
            veliDoldur();
            ogrenciDoldur();


        }

        private void ogrenciDoldur()
        {
            listView1.Items.Clear();

            foreach (Ogrenci og in Tanimlar.Ogrenciler)
            {
                ListViewItem satir = new ListViewItem(og.OgrenciAdi);
                satir.SubItems.Add(og.OgrenciSoyadi);
                satir.SubItems.Add(og.Memleketi);
                satir.SubItems.Add(og.DogumTarihi.ToShortDateString());
                satir.SubItems.Add(og.Velisi.ToString());
                satir.SubItems.Add(og.Velisi.TelefonNo);
                listView1.Items.Add(satir);
            }
        }

        private void veliDoldur()
        {
            cmbVelisi.Items.Clear();

            foreach (Veli veli in Tanimlar.Veliler)
            {
                cmbVelisi.Items.Add(veli);
            }
        }

        private void dersDoldur()
        {
            clbDersleri.Items.Clear();

            foreach (Ders ders in Tanimlar.DersLer)
            {
                clbDersleri.Items.Add(ders);

            }
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();

            o.OgrenciAdi = txtOgrenciAdi.Text;
            o.OgrenciSoyadi = txtOgrenciSoyadi.Text;
            o.Memleketi = txtMemleketi.Text;
            o.DogumTarihi = dtpDogumTarihi.Value;
            o.Velisi = cmbVelisi.SelectedItem as Veli;

            foreach (object item in clbDersleri.CheckedItems)
            {
                o.Dersler.Add(item as Ders);

            }
            Tanimlar.Ogrenciler.Add(o);

            ogrenciDoldur();
             
        }

        private void btnYeniVeliEkle_Click(object sender, EventArgs e)
        {
            frmVeliKayit frm = new frmVeliKayit();
            frm.ShowDialog();

            if (frm.Tag !=null)
            {
                Tanimlar.Veliler.Add(frm.Tag as Veli);
                veliDoldur();
                cmbVelisi.SelectedItem = frm.Tag;
            }
        }

    }
}
