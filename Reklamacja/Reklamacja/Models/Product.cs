﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reklamacja.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Serialnumber { get; set; }
        public int ShopId { get; set; }
    }
}