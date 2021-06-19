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
        public float Price { get; }

        public SKU(string id, float price)
        {
            this.ID = id;
            this.Price = price;
        }
    }
}
