﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Cart
    {
        public List<SKU> Items = new List<SKU>();

        public Cart(List<SKU> items)
        {
            this.Items = items;
        }
    }
}