using System;
using System.Net;
using System.Net.Mail;

namespace CokKatmanli.BLL
{
    class MailHelper
    {

        //-----------------------------------------------------MAIL GONDERME------------------------------------------------------------
        internal static void MailGonder(string kimlere, string baslik, string icerik)
        {
            try
            {
                MailMessage mail = new MailMessage(); //mail nesnemiz
                mail.Subject = baslik;
                mail.Body = icerik;
                mail.IsBodyHtml = true;  //icerikteki hmtl taglerinin gorunmemesı true oluyor.ama varsada mesela br varsa tag olarak satırı asag gecırıyor.
                mail.Priority = MailPriority.High;  //maili yuksek oncelikli gondermesi anlamında.
                mail.From = new MailAddress("billgates@hotmail.com");  //mesela ben yollamıs olsamda bu mail adına yllandıgını gosterebılırım.
                mail.To.Add(kimlere);  //mehmet.yildiz@abc.com;ayse@yahoo.com gibi..




                //Simple Mail Transfer Protocol==>smtp
                SmtpClient smtp = new SmtpClient();  //maili goncerıcek nesnemiz.
                //Simdi gmail in ayarlarını vermemiz gerekiyor:
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 465;  //587
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("gecelerinlordu100@gmail.com", "123456789@1");
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                              
            }

           
           


        }
    }
}
