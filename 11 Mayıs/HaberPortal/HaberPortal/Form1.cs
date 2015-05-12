using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HaberContext entity = new HaberContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriDoldur();
            cmbKategoriler.SelectedIndex = 0;
            haberDoldur();
        }

        private void haberDoldur()
        {
            dataGridView1.Rows.Clear();

            foreach (Haber item in entity.Haberler)
            {
                dataGridView1.Rows.Add(item.HaberBaslik,
                                        item.HaberIcerik,
                                        item.Kategorisi.KategoriAdi,
                                        item.HaberTarihi);
            }
        }

        private void kategoriDoldur()
        {
            cmbKategoriler.Items.Clear();
            cmbKategoriler.Items.Add("seçiniz...");
            cmbKategoriler.Items.Add("___ Yeni kategori ekle");

            foreach (Kategori item in entity.Kategoriler)
            {
                cmbKategoriler.Items.Add(item);
            }

        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedIndex == 1)
            {
                frmKategori frm = new frmKategori();
                DialogResult sonuc = frm.ShowDialog();

                if (sonuc == System.Windows.Forms.DialogResult.OK)
                {
                    kategoriDoldur();
                    cmbKategoriler.SelectedIndex = cmbKategoriler.Items.Count - 1;
                }
                else
                {
                    cmbKategoriler.SelectedIndex = 0;
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedIndex > 1)
            {
                Haber haber = new Haber();
                haber.HaberBaslik = txtBaslik.Text;
                haber.HaberIcerik = txtIcerik.Text;
                haber.Kategorisi = cmbKategoriler.SelectedItem as Kategori;
                haber.HaberTarihi = DateTime.Now;

                entity.Haberler.Add(haber);
                entity.SaveChanges();

                txtBaslik.Clear();
                txtIcerik.Clear();
                cmbKategoriler.SelectedIndex = 0;


                haberDoldur();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = entity.Database.ExecuteSqlCommand("update Haberler set HaberTarihi=@tarih where HaberId in (@id1,@id2,@id3)",
                 new SqlParameter("@tarih", Convert.ToDateTime("23.05.2011", CultureInfo.GetCultureInfo("tr-TR"))),
                 new SqlParameter("@id1", 1),
                  new SqlParameter("@id2", 2),
                   new SqlParameter("@id3", 3));
            MessageBox.Show(sonuc.ToString());
            for (int i = 0; i < 3; i++)
            {
                entity.Entry(entity.Haberler.ToArray()[i]).Reload();  //burada da tarih guncelleme yaptık.
            } 

            haberDoldur();
        }
    }
}
