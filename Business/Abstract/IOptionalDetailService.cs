using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOptionalDetailService
    {
        IDataResult<List<OptionalDetail>> GetAll();
        IDataResult<OptionalDetail> GetById(int id);
        IResult Add(OptionalDetail optionalDetail);
        IResult Update(OptionalDetail optionalDetail);
        IResult Delete(OptionalDetail optionalDetail);
    }
}
