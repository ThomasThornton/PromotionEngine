using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SKU> inventory = new List<SKU>();

            inventory.Add(new SKU("A", 50));
            inventory.Add(new SKU("B", 30));
            inventory.Add(new SKU("C", 20));
            inventory.Add(new SKU("D", 15));

            Cart ScenarioA = new Cart();
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart ScenarioB = new Cart();
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "C"));

            Cart ScenarioC = new Cart();
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "A"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "B"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "C"));
            ScenarioA.Items.Add(inventory.Find(x => x.ID == "D"));
        }
    }
}
