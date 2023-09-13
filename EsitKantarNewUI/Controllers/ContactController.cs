using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entities.Dto;
using EsitKantarNewUI.ViewModel;
using FluentValidation.Results;
using KantarCore.Entities.Concrete;
using KantarCore.Entities.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsitKantarNewUI.Controllers
{
    public class ContactController : Controller
    {
        IMailService _mailService;
        private readonly IStringLocalizer<ContactController> _localizer;
        public ContactController(IMailService mailService, IStringLocalizer<ContactController> localizer)
        {
            _mailService = mailService;
            _localizer = localizer;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var mailDetail = _mailService.GetAllProduct().Data;
            return View(mailDetail);
        }
       
        public JsonResult Index(List<MailDetailDto> userMail)
        {            
            UserMailValidator userMailValidator = new UserMailValidator();
            ValidationResult results = userMailValidator.Validate(userMail.FirstOrDefault());
            List<EmailResult> emailResult = new List<EmailResult>();
            if (results.IsValid)
            {
                MailDetailDto user = new MailDetailDto()
                {
                    AdSoyad = userMail.FirstOrDefault().AdSoyad,
                    Email = userMail.FirstOrDefault().Email,
                    TelNo = userMail.FirstOrDefault().TelNo,
                    MailIcerik = userMail.FirstOrDefault().MailIcerik,
                    ProductName = userMail.FirstOrDefault().ProductName
                };
                _mailService.SendMail(user);
                var model = new EmailResult();
                model.status = "Ok";
                model.message = _localizer["mailSuccess"];
                emailResult.Add(model);
                return Json(emailResult);
            }
            else
            {                
                foreach (var item in results.Errors)
                {                    
                    var Model = new EmailResult();
                    Model.status = "Error";
                    Model.message = item.ErrorMessage;
                    emailResult.Add(Model);
                }
                return Json(emailResult);
            }              
        }       
    }
}
