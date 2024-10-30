﻿using OrderServise.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServise.Domain.Entities
{
    public class Product: BaseEntity
    {
        public int CityId { get; set; }
        public int? Price { get; set; }
        public int FactoryId { get; set; }
        public string Name { get; set; }
        public List<ProductSize> ProductSize { get; set;}
        public List<ProductFeature> ProductFeatures { get; set; }
      
        public bool IsActive { get; set; }
    }
}
