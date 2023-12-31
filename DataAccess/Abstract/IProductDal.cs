﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal :  IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails(string value);
    }
}
