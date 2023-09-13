using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFeaturesDetailService
    {
        IDataResult<List<FeaturesDetail>> GetAllFeaturesDetails();
        IDataResult<FeaturesDetail> GetById(int id);
        IResult Add(FeaturesDetail featuresDetail);
        IResult Update(FeaturesDetail featuresDetail);
        IResult Delete(FeaturesDetail featuresDetail);

    }
}
