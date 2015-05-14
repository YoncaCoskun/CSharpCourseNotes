using System;
using System.Windows.Forms;

namespace XML_JSON
{
   public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TelefonNumarasi { get; set; }

        public Cinsiyetler Cinsiyet{ get; set; }

        public byte[] Fotograf { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}",this.Ad,this.Soyad);
        }

        public static void formuTemizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Now;
                }
                else if (item is PictureBox)
                {
                    (item as PictureBox).ImageLocation = null;
                }
            }
        }
       
    }
   public enum Cinsiyetler
   {
       Erkek = 0,
       Kadın = 1
   }
}
