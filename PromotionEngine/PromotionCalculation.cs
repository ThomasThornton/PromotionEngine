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

            int promotionCount = promotion.Info.Sum(e => e.Amount);

            while (cartCount >= promotionCount)
            {
                total += promotion.PromotionPrice;
                cartCount -= promotionCount;
            }

            return total;
        }
    }
}
