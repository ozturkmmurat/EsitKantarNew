using KantarCore.Entities.Concrete;
using KantarCore.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Core.Utilites.MailHelper
{
    public interface IMailHelper
    {
        SmtpClient Update(List<string>mailAliciEposta, string mailGonderenEposta,string gonderenSifre, int port,string smtp, MailDetailDto userMail);
        
    }
}
