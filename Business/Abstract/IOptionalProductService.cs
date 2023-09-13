using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOptionalProductService
    {
        IDataResult<List<OptionalProduct>> GetAll();
        IDataResult<OptionalProduct> GetById(int id);
        IResult Add(OptionalProduct optionalProduct);
        IResult Update(OptionalProduct optionalProduct);
        IResult Delete(OptionalProduct optionalProduct);
    }
}
