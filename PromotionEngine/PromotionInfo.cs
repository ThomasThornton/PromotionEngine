using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class PromotionInfo
    {
        public string SKU { get; set; }
        public int Amount { get; set; }

        public PromotionInfo(string sku, int amount)
        {
            this.SKU = sku;
            this.Amount = amount;
        }
    }
}
