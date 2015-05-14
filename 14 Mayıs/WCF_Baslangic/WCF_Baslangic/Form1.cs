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

namespace WCF_Baslangic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------------------------------WCF----------------------------------------------
            //WCF - windows Comminucation Foundation
            //      windows Iletisim Cozumleri
            //Elinizde buluınan xml e nasıl istemciye ulastırıcagmızın cozumunu bıze sunuyor.(var olan bır yapıyı baska bır kullanıcıya nasıl ulastırıcagımızı)

            //wcf de gorulecek konular:
            //Socket
            //Remouting
            //Web Service
            //WCF Service
            //MSMQ(Microsoft Message Queue)

            //----------------------------SOCKET-------------------------------------------
            //Ikı farklı bılgısayar arasındakı ıletısımı saglar.
            //kartus hazırlanacak,kartusu bılgısayarın socketıne takınca ,baska bı bılgısayarda o port dınlenecek.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //basınca makınamda bir port acılsın ıstıyoruz.(Bizim tarafımızdakı sunucu kuruldu)

            Socket soket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);  //transmission control protocol  soket nerde ıletısım kurulacagını belırttı.

            soket.Bind(new IPEndPoint(IPAddress.Parse("10.5.22.15"), 23500));   //soketı bılgısayara baglama ıslemı  kendı makınamızın ıo adresı verılır.(soket makınaya baglandı)

            //bu soket kac kısıyı bekleyecek:100 kisi
            soket.Listen(100);

            //karsıdan gelıcek olan baglantıyı beklerken kabul etmelıyız:
           Socket tayfun=soket.Accept();  //tayfunun soketı yakalandı.

            //byte dızısı hazırlamalıyız.
            byte[] data=new byte[1024];

            //tayfunun post ettıgı bırseyı almak ıcın:
           tayfun.Receive(data);

            //gelen datayı string e cevırceksın.

           string metin = Encoding.UTF8.GetString(data);
           MessageBox.Show(metin);
        }
    }
}
