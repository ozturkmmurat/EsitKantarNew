using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FeaturesProduct : IEntity
    {
        public int Id { get; set; }
        public int FeaturesDetailsId { get; set; }
        public int ProductId { get; set; }
        public int FeaturesImgId { get; set; }
    }
}
