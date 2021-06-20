using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineTestProject
{
    [TestClass]
    public class UnitTestB
    {
        private const double Expected = 370;

        [TestMethod]
        public void TestMethod1()
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

            Cart scenarioB = new Cart();
            scenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "A"), 5));
            scenarioB.Items.AddRange(Enumerable.Repeat(inventory.Find(x => x.ID == "B"), 5));
            scenarioB.Items.Add(inventory.Find(x => x.ID == "C"));

            List<double> promotionPrices = promotions.Select(promotion => PromotionCalculation.GetCartTotal(scenarioB, promotion)).ToList();
            double originalPrice = scenarioB.Items.Sum(x => x.Price);
            double promotionPrice = promotionPrices.Sum();
            if (promotionPrice == 0)
                promotionPrice = originalPrice;

            double result = promotionPrice;

            Assert.AreEqual(Expected, result);
        }
    }
}
