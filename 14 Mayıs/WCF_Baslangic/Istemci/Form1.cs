using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istemci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //istemci tarafı yapılıyor.

            Socket soket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            soket.Connect(new IPEndPoint(IPAddress.Parse("10.5.22.15"),23500));

            //eger sunucu basarılı sekılde kabul ettıyse,bu socket artık send ıslemı yapabılır.

            soket.Send(Encoding.UTF8.GetBytes("Merhaba Dunya"));
        }
    }
}
