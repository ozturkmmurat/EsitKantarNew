﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FeaturesDetail : IEntity
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string FeaturesTitle { get; set; }
        public string FeaturesDescription { get; set; }
    }
}
