using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    static class PromotionCalculation
    {
        public static double GetCartTotal(Cart cart, Promotion promotion)
        {
            double total = 0;

            int cartCount = cart.Items.GroupBy(x => x.ID).Where(y => promotion.Info.Any(z => y.Key == z.SKU && y.Count() >= z.Amount)).Select(y => y.Count()).Sum();

            var skuID = cart.Items.GroupBy(x => x.ID).Where(y => promotion.Info.Any(z => y.Key == z.SKU && y.Count() >= z.Amount)).Select(y => y.Key);
            
            int promotionCount = promotion.Info.Sum(e => e.Amount);

            while (cartCount >= promotionCount)
            {
                total += promotion.PromotionPrice;
                cartCount -= promotionCount;
            }

            if (cartCount > 0 && skuID.Count() > 0 && promotion.Info.Count() < 2)
            {
                var temp = skuID.First();
                double skuPrice = cart.Items.Find(x => x.ID == temp).Price;
                total += cartCount * skuPrice;
            }

            return total;
        }
    }
}
