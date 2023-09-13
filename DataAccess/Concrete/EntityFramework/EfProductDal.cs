using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EsitKantarNewContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(string value)
        {
            using (EsitKantarNewContext context = new EsitKantarNewContext())
            {              

                var featuresProduct = context.FeaturesProducts.Where(x => x.ProductId == context.Products.Where(y => y.ProductName == value).FirstOrDefault().Id).ToList();
                var optionalProduct = context.OptionalProducts.Where(x => x.ProductId == context.Products.Where(y => y.ProductName == value).FirstOrDefault().Id).ToList();
                var generalProduct = context.GeneralProducts.Where(x => x.ProductId == context.Products.Where(y => y.ProductName == value).FirstOrDefault().Id).ToList();
                var postResult = new List<ProductDetailDto>();

                var productFeatures = from p in featuresProduct.ToList()
                                      join pd in context.FeaturesDetails on p.FeaturesDetailsId equals pd.Id
                                      join pi in context.FeaturesImgs on p.FeaturesImgId equals pi.Id
                                      into temp from t in temp.DefaultIfEmpty()
                                      join pr in context.Products on p.ProductId equals pr.Id
                                      join l in context.Languages on pd.LanguageId equals l.Id
                                      select new ProductDetailDto
                                      {
                                          ProductId = p.ProductId,
                                          ProductName = pr.ProductName,
                                          ImgLink = t.ImgName,
                                          Url = t.Url,
                                          FeaturesTitle = pd.FeaturesTitle,
                                          FeaturesId = pd.Id,
                                          FeaturesDescription = pd.FeaturesDescription,
                                          LanguageName = l.LanguageName
                                      };

                postResult.AddRange(productFeatures);

                var productOptional = from p in optionalProduct.ToList()
                                      join od in context.OptionalDetails on p.OptionalDetailsId equals od.Id
                                      join oi in context.OptionalImgs on p.ImageId equals oi.Id
                                      into temp from t in temp.DefaultIfEmpty()
                                      join or in context.Products on p.ProductId equals or.Id
                                      join l in context.Languages on od.LanguageId equals l.Id
                                      select new ProductDetailDto
                                      {
                                          OptionalId = od.Id,
                                          ProductId = or.Id,
                                          ProductName = or.ProductName,
                                          OptionalTitle = od.OptionalTitle,
                                          OptionalDescription = od.OptionalDescription,
                                          ImgLink = t.ImgName,
                                          LanguageName = l.LanguageName
                                      };

                postResult.AddRange(productOptional);


                var generalProducts = from g in generalProduct.ToList()
                                      join gd in context.GeneralDetails on g.GeneralDetailsId equals gd.Id
                                      join i in context.Images on g.ImgId equals i.Id
                                      into temp from t in temp.DefaultIfEmpty()
                                      join p in context.Products on g.ProductId equals p.Id
                                      join l in context.Languages on gd.LanguageId equals l.Id
                                      select new ProductDetailDto
                                      {
                                          ProductId = p.Id,
                                          GeneralTitle = gd.GeneralTitle,
                                          GeneralDescription = gd.GeneralDescription,
                                          ImgLink = t.ImgName,
                                          LanguageName = l.LanguageName
                                      };
                postResult.AddRange(generalProducts);


                return postResult.ToList();
            }
        }

      
    }
}
