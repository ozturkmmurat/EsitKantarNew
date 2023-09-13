using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class GeneralDetail : IEntity
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string GeneralTitle { get; set; }
        public string GeneralDescription { get; set; }
    }
}
