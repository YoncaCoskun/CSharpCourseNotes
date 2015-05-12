using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serilestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------------------------------SERILESTIRME----------------------------------------------------

            //serilestirme= herseyi byte dizisine donucturme yada donusturulmus bırseyo nyte a cevırme ıslemlerının hepsi serilestirme islemidir.

            //char harf = 'a';
            //int sonuc=(int)harf;
            //MessageBox.Show(sonuc.ToString());


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf = "a";
            byte[] dizi = Encoding.UTF8.GetBytes(harf);

            foreach (byte item in dizi)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = "Bu günüm sensiz geçti.";


            //yukarıdaki metni byte dizisi yapın ve listbox a her bir byte ı yukleyınız.

            byte[] dizi = Encoding.UTF8.GetBytes(metin);

            foreach (byte item in dizi)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] dizi=new byte[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dizi[i] = Convert.ToByte(listBox1.Items[i]);              
               
            }
            string metin = Encoding.UTF8.GetString(dizi);
            MessageBox.Show(metin);           

        
        }
    }
}
