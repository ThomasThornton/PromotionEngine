using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Promotion
    {
        public int ID { get; set; }
        public List<PromotionInfo> Info { get; set; }
        public double PromotionPrice { get; set; }

        public Promotion(int id, List<PromotionInfo> info, double promotionprice)
        {
            this.ID = id;
            this.Info = info;
            this.PromotionPrice = promotionprice;
        }
    }
}
