using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeOyun
{
    public partial class OyunKayitForm : Form
    {
        Form1 anaform;
        public OyunKayitForm(Form1 form)
        {
            InitializeComponent();
            anaform = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OyunKayit kayit = new OyunKayit();
            kayit.KayitAdi = textBox1.Text;
            anaform.oyunKaydet(kayit);
            doldur();
        }

        private void doldur()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(anaform.kayitlar.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                OyunKayit kayit = listBox1.SelectedItem as OyunKayit;
                anaform.kayitAc(kayit);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void OyunKayitForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OyunKayit kayit = listBox1.SelectedItem as OyunKayit;
            textBox1.Text = kayit.ToString();
        }
    }
}
