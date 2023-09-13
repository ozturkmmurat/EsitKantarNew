using KantarCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KantarCore.Entities.Concrete
{
    public class Mail : IEntity
    {
        public string MailGonderen { get; set; }
        public string MailGonderenSifre { get; set; }
        public string GonderenSmtp { get; set; }
        public int GonderenPort { get; set; }
        public List<string> MailAliciListesi { get; set; }
     
    }

    
}
