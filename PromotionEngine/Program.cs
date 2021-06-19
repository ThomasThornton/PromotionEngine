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

            Cart ScenarioA = new Cart();
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart ScenarioB = new Cart();
            ScenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "A"), 5));
            ScenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "B"), 5));
            ScenarioB.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart ScenarioC = new Cart();
            ScenarioC.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "A"), 3));
            ScenarioC.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "B"), 5));
            ScenarioC.Items.Add(inventory.Find(x => x.ID == "C"));
            ScenarioC.Items.Add(inventory.Find(x => x.ID == "D"));
        }
    }
}
