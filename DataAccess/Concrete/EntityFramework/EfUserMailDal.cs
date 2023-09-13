using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using KantarCore.Entities.Concrete;
using KantarCore.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserMailDal : EfEntityRepositoryBase<UserMail, EsitKantarNewContext>, IUserMailDal
    {
        public List<MailDetailDto> GetMailDetails()
        {
            UserMail mail = new UserMail();
            using (EsitKantarNewContext context = new EsitKantarNewContext())
            {
                var product = from p in context.Products
                              join l in context.Languages on p.LanguageId equals l.Id
                              select new MailDetailDto
                              {
                                  AdSoyad = mail.AdSoyad,
                                  Email = mail.Email,
                                  MailIcerik = mail.MailIcerik,
                                  TelNo = mail.TelNo,
                                  ProductName = p.ProductName,
                                  LanguageName = l.LanguageName
                              };
                return product.ToList();
            }
        }
    }
}