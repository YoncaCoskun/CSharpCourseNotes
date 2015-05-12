using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortal
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAdi = txtKategoriAdi.Text;
            kategori.Aciklamasi = txtAciklama.Text;

            HaberContext entity = new HaberContext();
            entity.Kategoriler.Add(kategori);
            entity.SaveChanges();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
