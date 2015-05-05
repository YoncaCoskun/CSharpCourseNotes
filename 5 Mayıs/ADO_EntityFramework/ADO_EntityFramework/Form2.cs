using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EntityFrameworkModelFirst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
           OkulDbContainer data=new OkulDbContainer();

           private void Form2_Load(object sender, EventArgs e)
           {
               doldur();

           }
         
         private void doldur(){

             //lambda ile listbox doldurma

            listBox1.Items.Clear();
            listBox1.Items.AddRange(data.Veliler.Select(veli=>veli.VeliAdi+" "+veli.VeliSoyadi).ToArray());

            }
           
    }
}
