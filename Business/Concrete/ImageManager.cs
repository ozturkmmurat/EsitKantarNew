using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imagedal;
        public ImageManager(IImageDal imageDal)
        {
            _imagedal = imageDal;
        }
        public IResult Add(Image ımage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Image ımage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Image>> GetAllImage()
        {
          var result =  _imagedal.GetAll();
           return new SuccessDataResult<List<Image>>(result);

        }

        public IDataResult<List<Image>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Image>> GetImageByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Image ımage)
        {
            throw new NotImplementedException();
        }
    }
}
