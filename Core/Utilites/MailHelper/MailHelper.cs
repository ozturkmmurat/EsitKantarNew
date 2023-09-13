using KantarCore.Entities.Concrete;
using KantarCore.Entities.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Core.Utilites.MailHelper
{
    public class MailHelper : IMailHelper
    {
        public SmtpClient Update(List<string> mailAliciEposta, string mailGonderenEposta,string gonderenSifre, int port,string smtp, MailDetailDto userMail)
        {
            SmtpClient sc = new SmtpClient(smtp, port);
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential(mailGonderenEposta, gonderenSifre);
            sc.EnableSsl = false;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(mailGonderenEposta, userMail.AdSoyad);
            foreach (var item in mailAliciEposta)
            {
                mail.To.Add(item);
            }
            mail.Subject = "Esit Kantar'dan teklif mesajı var";
            mail.IsBodyHtml = true;
            string htmlString = $"<h5>http://kantar.esit.com.tr/ Web Sitesinden mail var. </h5>  <h5> Ad Soyad :  </h5> {userMail.AdSoyad}  <h5>Email  : </h5> {userMail.Email}   <h5> Tel No : </h5> {userMail.TelNo}   <h5> Mail İçeriği : </h5> {userMail.MailIcerik} <h5> Teklif İstenilen Ürün : </h5> {userMail.ProductName} ";
            mail.Body = htmlString;
            mail.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
            mail.SubjectEncoding = System.Text.Encoding.GetEncoding("utf-8");
            sc.Send(mail);

            return null;

        }

       
    }
}
