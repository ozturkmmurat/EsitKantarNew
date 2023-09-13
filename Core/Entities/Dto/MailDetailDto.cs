using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KantarCore.Entities.Dto
{
    public class MailDetailDto : IDto
    {
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string MailIcerik { get; set; }
        public string ProductName { get; set; }
        public string LanguageName { get; set; }
    }
}
