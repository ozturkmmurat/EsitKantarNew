using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public IResult Add(Category category)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
