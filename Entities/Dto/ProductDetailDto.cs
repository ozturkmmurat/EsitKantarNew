using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public int FeaturesId { get; set; }
        public int OptionalId { get; set; }
        public int GeneralId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string FeaturesTitle { get; set; }
        public string FeaturesDescription { get; set; }
        public string OptionalTitle { get; set; }
        public string OptionalDescription { get; set; }
        public string GeneralTitle { get; set; }
        public string GeneralDescription { get; set; }
        public string CategoryName { get; set; }
        public string ImgLink { get; set; }
        public string Url { get; set; }
        public string ProductName { get; set; }        
    }
}
