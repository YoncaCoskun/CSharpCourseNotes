using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulaması1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dunya");  //mbox ıle kısa sekılde getırebılıyoruz

            //textbox takı bılgıyı message bozta goruntulemek ıcın:
            MessageBox.Show(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //listboxlara ekleme yaptık

            listBox1.Items.Add("test");
            listBox1.Items.Add(12);
            listBox1.Items.Add(btnButton);
            listBox1.Items.Add(listBox1);
            listBox1.Items.Add(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //Form bizimForm= (Form)listBox1.Items[4]; casting deniliyordu
            Form bizimForm = listBox1.Items[4] as Form;  //unboxing  sadece c# a ozeldir
            bizimForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
