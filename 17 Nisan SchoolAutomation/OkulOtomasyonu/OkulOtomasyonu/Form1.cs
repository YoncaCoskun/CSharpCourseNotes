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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //cıkıs a basınca form kapanır.
        }

        private void veliKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form cocuk in this.MdiChildren) //velikayıta tıkladıgımızda bırden fazla calısmasını engelledık bu donguyle.
            {
                if (cocuk is frmVeliler)
                {
                    cocuk.Focus();
                    return;
                }
            }
            frmVeliler frm = new frmVeliler();
            frm.MdiParent = this;  //from1 in cocugu oldugu gosterır
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if !DEBUG
		
            frmLogin frm = new frmLogin();
            DialogResult sonuc= frm.ShowDialog();

            if (sonuc==System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
                return;

            }  
	#endif

            

            Tanimlar.Ogrenciler=new List<Ogrenci>();
            Tanimlar.Veliler = new List<Veli>();
            Tanimlar.DersLer=new List<Ders>();
        }

        private void dersKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmDersKayit)
                {
                    item.Focus();
                    return;
                }
            }
            frmDersKayit frm = new frmDersKayit();

            frm.MdiParent = this;
            frm.Show();
        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item is frmOgrenciKayit)
                {
                    item.Focus();
                    return;
                }
            }
            frmOgrenciKayit frm = new frmOgrenciKayit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.ShowDialog();
        }
    }
}
