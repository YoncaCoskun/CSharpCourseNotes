using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSSokuyucu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            XmlDocument dokuman = new XmlDocument();
            dokuman.Load(comboBox1.Text);

            XmlElement root = dokuman.DocumentElement;

            XmlNodeList liste = root.GetElementsByTagName("item");

            foreach (XmlNode haber in liste)
            {
                ListViewItem satir = new ListViewItem(haber.SelectSingleNode("title").InnerText);
                satir.SubItems.Add(temizle(haber.SelectSingleNode("description").InnerText));
                satir.SubItems.Add(haber.SelectSingleNode("pubDate").InnerText);
                satir.SubItems.Add(haber.SelectSingleNode("link").InnerText);
                listView1.Items.Add(satir);

            }
        }

        private string temizle(string kirli)  //decription daki html tag larını kaldırabilmek icin yaptık
        {
            while (true)
            {
                int basIndex = kirli.IndexOf("<");

                if (basIndex > -1)
                {
                    int bitisIndex = kirli.IndexOf(">", basIndex);
                    kirli = kirli.Remove(basIndex, (bitisIndex - basIndex + 1));
                }
                else
                {
                    break;
                }
            }

            return kirli.Trim();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string link = listView1.SelectedItems[0].SubItems[3].Text;
                webBrowser1.Navigate(link);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true; //js de hata yapmıs hatayı gormememız ıcın yapıyoruz
           
        }
    }
}
