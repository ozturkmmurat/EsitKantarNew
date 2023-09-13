using Business.Abstract;
using Business.Constans;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);

            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAllProduct()
        {
            var result = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(result);
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetails(string value)
        {
            var result = _productDal.GetProductDetails(value);
            return new SuccessDataResult<List<ProductDetailDto>>(result);
        }

        public IDataResult<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetProductByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
