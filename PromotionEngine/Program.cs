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

            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion(1, "A", 3, 130),
                new Promotion(2, "B", 2, 45)
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
