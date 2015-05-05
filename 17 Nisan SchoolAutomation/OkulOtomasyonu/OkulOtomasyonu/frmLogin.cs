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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="yonca"  && textBox2.Text=="123")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
             
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yada parola hatalı lutfen tekrar deneyınız");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult!= System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        
    }
}
