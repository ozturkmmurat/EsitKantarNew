﻿using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFeaturesProductService
    {
        IDataResult<List<FeaturesProduct>> GetAllFeaturesProduct();
        IDataResult<FeaturesProduct> GetById(int id);
    }
}
