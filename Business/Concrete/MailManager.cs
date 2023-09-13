using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilites.MailHelper;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Dto;
using KantarCore.Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using KantarCore.Entities.Dto;
namespace Business.Concrete
{
    public class MailManager : IMailService
    {
        IMailHelper _maiiHelper;
        public IConfiguration Configuration { get; }
        Mail _mail;
        IUserMailDal _mailDal;
        public MailManager(IMailHelper mailHelper, IConfiguration config, IUserMailDal mailDal)
        {
            _maiiHelper = mailHelper;
            Configuration = config;
            _mail = Configuration.GetSection("Mail").Get<Mail>();
            _mailDal = mailDal;

        }
        [ValidationAspect(typeof(UserMailValidator))]
        public void SendMail(MailDetailDto userMail)
        {
            MailDetailDto user = new MailDetailDto()
            {
                AdSoyad = userMail.AdSoyad,
                Email = userMail.Email,
                TelNo = userMail.TelNo,
                MailIcerik = userMail.MailIcerik,
                ProductName = userMail.ProductName
            };
            
          var result =  _maiiHelper.Update(mailAliciEposta : _mail.MailAliciListesi,mailGonderenEposta: _mail.MailGonderen,
             gonderenSifre: _mail.MailGonderenSifre, port:_mail.GonderenPort,smtp: _mail.GonderenSmtp,user);
        }

        public IDataResult<List<MailDetailDto>> GetAllProduct()
        {
            return new SuccessDataResult<List<MailDetailDto>>(_mailDal.GetMailDetails(), "Tüm Veriler Getirildi");
        }
    }
}
