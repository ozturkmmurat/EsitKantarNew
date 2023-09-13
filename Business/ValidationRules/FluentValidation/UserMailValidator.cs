using Entities.Dto;
using FluentValidation;
using KantarCore.Entities.Concrete;
using KantarCore.Entities.Dto;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Business.ValidationRules.FluentValidation
{
    public class UserMailValidator : AbstractValidator<MailDetailDto>
    {
        public UserMailValidator()
        {

            RuleFor(u => u.AdSoyad).Length(4, 30).WithMessage(ErrorMessage.AdSoyadUzunluk);
            RuleFor(u => u.AdSoyad).NotNull().WithMessage(ErrorMessage.AdSoyad);
            RuleFor(u => u.Email).EmailAddress().WithMessage(ErrorMessage.EmailKontrol);
            RuleFor(u => u.Email).NotEmpty().WithMessage(ErrorMessage.Email);
            RuleFor(u => u.TelNo).Length(10, 11).WithMessage(ErrorMessage.TelefonUzunluk);
            RuleFor(u => u.TelNo).NotEmpty().WithMessage(ErrorMessage.Telefon);
            RuleFor(u => u.MailIcerik).Length(20, 500);
            RuleFor(u => u.MailIcerik).NotEmpty().WithMessage(ErrorMessage.MailIcerik);
            
        }


    }
}
