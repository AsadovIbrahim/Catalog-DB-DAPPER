﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DB.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string? Country { get; set; }
        public decimal Cost { get; set; }
    }
}
