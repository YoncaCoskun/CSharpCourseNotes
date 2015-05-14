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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        Form1 anaForm;

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anaForm.oyunaBasla();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaForm.oyunaBasla();
            button5_Click(null, null);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Form seffafForm = this.Tag as Form;
            anaForm = seffafForm.Tag as Form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OyunKayitForm frm = new OyunKayitForm(anaForm);
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == System.Windows.Forms.DialogResult.OK)
            {
                button5_Click(null, null);
            }
        }
    }
}
