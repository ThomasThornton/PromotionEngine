using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Promotion
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public int Amount { get; set; }
        public float PromotionPrice { get; set; }

        public Promotion(int id, string sku, int amount, float promotionprice)
        {
            this.ID = id;
            this.SKU = sku;
            this.Amount = amount;
            this.PromotionPrice = promotionprice;
        }
    }
}
