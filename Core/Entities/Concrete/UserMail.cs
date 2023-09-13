using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KantarCore.Entities.Concrete
{
    public class UserMail : Core.Entities.IEntity
    {
        
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string MailIcerik { get; set; }
    }
}
