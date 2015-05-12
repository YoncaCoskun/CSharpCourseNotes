using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Serilestirme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Metin dosyaları|*.txt|Sql Dosyası|*.sql|Tüm Dosyalar|*.*";
            DialogResult sonuc= openFileDialog1.ShowDialog();

            //eger kullanıcı herhangı bırsey secıp ac dugmesıne bastıysa bunu kontrolunu yapalım:
            if (sonuc==System.Windows.Forms.DialogResult.OK)
            {
                FileInfo bilgi = new FileInfo(openFileDialog1.FileName);
                listBox1.Items.Clear();
                listBox1.Items.Add("Dosya Adı : "+bilgi.Name);
                listBox1.Items.Add("Dosya Yolu : " + bilgi.FullName);
                listBox1.Items.Add("Uzantısı : " + bilgi.Extension);
                listBox1.Items.Add("Boyutu : " + bilgi.Length);
                listBox1.Items.Add("Oluşturma Tarihi : " + bilgi.CreationTime);
                listBox1.Items.Add("Değiştirme Tarihi : " + bilgi.LastWriteTime);
                listBox1.Items.Add("Erişme Tarihi : " + bilgi.LastAccessTime);
            }
        }
    }
}
