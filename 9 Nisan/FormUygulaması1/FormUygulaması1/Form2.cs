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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (object item in listBox1.Items)
            {
                listBox2.Items.Add(item); //listbox1 ıcındekıleri listbox2 ye aktarır
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
