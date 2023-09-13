using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OptionalDetail : IEntity
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string OptionalTitle { get; set; }
        public string OptionalDescription { get; set; }
    }
}
