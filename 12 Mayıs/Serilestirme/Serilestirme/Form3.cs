using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serilestirme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream dosyaIslem = new FileStream("metin.txt",FileMode.Open);

            byte[] dizi=new byte[dosyaIslem.Length];

            dosyaIslem.Read(dizi, 0, dizi.Length);
            dosyaIslem.Close();

            string metin = Encoding.UTF8.GetString(dizi);
            MessageBox.Show(metin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = "Gözlerimi hiç açmadım. Yoklugun beni yenemedi.";

            byte[] buffer = Encoding.UTF8.GetBytes(metin);



            FileStream dosyaIslem = new FileStream("metin.txt", FileMode.OpenOrCreate);


            //offset=icerisine nekadarlık kısmı alıcaz anlamında
            dosyaIslem.Write(buffer, 0, buffer.Length);
            dosyaIslem.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  StreamReader ile dosyayı okutun
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //StreamWriter ile dosyaya yazın
        }

        
    }
}
