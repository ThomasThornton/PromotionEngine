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
        public List<PromotionInfo> Info { get; set; }
        public float PromotionPrice { get; set; }

        public Promotion(int id, List<PromotionInfo> info, float promotionprice)
        {
            this.ID = id;
            this.Info = info;
            this.PromotionPrice = promotionprice;
        }
    }
}
