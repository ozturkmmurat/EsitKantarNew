using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OptionalProduct : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OptionalDetailsId { get; set; }
        public int ImageId { get; set; }
    }
}
