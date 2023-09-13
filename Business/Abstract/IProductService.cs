using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllProduct();
        IDataResult<List<Product>> GetProductByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetails(string value);
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
