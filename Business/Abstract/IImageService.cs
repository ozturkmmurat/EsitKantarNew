using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAllImage();
        IDataResult<List<Image>> GetImageByProductId(int id);
        IDataResult<List<Image>> GetById(int id);
        IResult Add(Image ımage);
        IResult Update(Image ımage);
        IResult Delete(Image ımage);
    }
}
