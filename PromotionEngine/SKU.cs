using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class SKU
    {
        public string ID { get; }
        public double Price { get; }

        public SKU(string id, double price)
        {
            this.ID = id;
            this.Price = price;
        }
    }
}
