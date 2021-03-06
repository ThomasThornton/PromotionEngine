using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart
    {
        public List<SKU> Items = new List<SKU>();

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in Items)
                    total += item.Price;

                return total;
            }
        }
    }
}
