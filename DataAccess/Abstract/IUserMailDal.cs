using Core.DataAccess;
using KantarCore.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserMailDal : IEntityRepository<KantarCore.Entities.Concrete.UserMail>
    {
        List<MailDetailDto> GetMailDetails();
    }
}
