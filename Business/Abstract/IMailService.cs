using Core.Utilities.Result.Abstract;
using KantarCore.Entities.Dto;
using KantarCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMailService
    {
        void SendMail(MailDetailDto userMail);
        IDataResult<List<MailDetailDto>> GetAllProduct();
    }
}
