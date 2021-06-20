using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SKU> inventory = new List<SKU>()
            {
                new SKU("A", 50),
                new SKU("B", 30),
                new SKU("C", 20),
                new SKU("D", 15)
            };

            List<PromotionInfo> info1 = new List<PromotionInfo>();
            info1.Add(new PromotionInfo("A", 3));

            List<PromotionInfo> info2 = new List<PromotionInfo>();
            info2.Add(new PromotionInfo("B", 2));

            List<PromotionInfo> info3 = new List<PromotionInfo>();
            info3.Add(new PromotionInfo("C", 1));
            info3.Add(new PromotionInfo("D", 1));

            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion(1, info1, 130),
                new Promotion(2, info2, 45),
                new Promotion(3, info3, 30)
            };

            Cart scenarioA = new Cart();
            scenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            scenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            scenarioA.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart scenarioB = new Cart();
            scenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "A"), 5));
            scenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "B"), 5));
            scenarioB.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart scenarioC = new Cart();
            scenarioC.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "A"), 3));
            scenarioC.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "B"), 5));
            scenarioC.Items.Add(inventory.Find(x => x.ID == "C"));
            scenarioC.Items.Add(inventory.Find(x => x.ID == "D"));

            List<double> promotionPrices = promotions.Select(promotion => PromotionCalculation.GetCartTotal(scenarioA, promotion)).ToList();
            double originalPrice = scenarioA.Items.Sum(x => x.Price);
            double promotionPrice = promotionPrices.Sum();
            Console.WriteLine("Cart: ScenarioA, Original price: " + originalPrice + ", Promotion price: " + promotionPrice);

            promotionPrices = promotions.Select(promotion => PromotionCalculation.GetCartTotal(scenarioB, promotion)).ToList();
            originalPrice = scenarioB.Items.Sum(x => x.Price);
            promotionPrice = promotionPrices.Sum();
            Console.WriteLine("Cart: ScenarioB, Original price: " + originalPrice + ", Promotion price: " + promotionPrice);

            promotionPrices = promotions.Select(promotion => PromotionCalculation.GetCartTotal(scenarioC, promotion)).ToList();
            originalPrice = scenarioC.Items.Sum(x => x.Price);
            promotionPrice = promotionPrices.Sum();
            Console.WriteLine("Cart: ScenarioC, Original price: " + originalPrice + ", Promotion price: " + promotionPrice);
        }
    }
}
