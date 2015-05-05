using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MemoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mahkum mahkum = new Mahkum();  //instance aldık.

            //istemdısı kapatılmalardan karsımıza destructor cıkıyor.
            //eger bır pointerla bır nesneye erısılıyorsa ne yapılırsa yapılsın o sılınemez.
            //garbage colector a sılme emrı verılebılır

            mahkum = null;  //ram de bası bos gezen bır nesne oldu artık işaretli degıl (pointer)buyuzden sıldırılebılır.
            GC.Collect();  //ram da ıse yaramayan fazlalık olan herseyi siliyor.bu yontem eskı bır yontemdır.BU nesne tabanlı yok etme yontemıdır.

            //--------------------MSIL tabanlı yok etme(microsoft intermediate language)------------------------
            //daha gelısmıs yoketme yontemıdır.
            //bu yontemle yok etmöek ıstıyorsak destructor metot devredısı kalır.





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eger mahkum class ın msıl ıle yok edılmesını ıstıyorsak;
            //msıl ıle yoketmek ıstıyorsak bu Mahkum classın nın mutlaka disposal dan implement edılmıs olması gerekıyor.
            using (Mahkum mahkum=new Mahkum())
            {

            }
            using(SqlConnection connect=new SqlConnection()) //ram uzerınde sql connectıon nesnesı oldurulecek anlamındadır.
            {
                using (SqlCommand command=new SqlCommand("",connect))
                {

                }

            }
        }
    }
}
