﻿using OrderServise.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServise.Domain.Entities
{
    public class Size: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public List<ProductSize> ProductSize { get; set; }
    }
}
