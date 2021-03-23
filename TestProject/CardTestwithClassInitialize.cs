using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCardSimulation.Concrete;
using ShoppingCardSimulation.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class CardTestwithClassInitialize
    {
       private static CardManager cardManager;
        private static ShopCardElement ShopCardElement;

      
        [ClassInitialize]
        public static void CardTestInitialize(TestContext testContext)
        {
            cardManager = new CardManager(new InMemoryCardDal());
            ShopCardElement = new ShopCardElement
            {
                Id = 1,
                count = 15,
                Name = "ürün"
            };

            cardManager.AddCardItem(ShopCardElement);
        }

        [TestMethod]
        public void CardTestCount()
        {

            var beklenen = 1;

            var cardItem = cardManager.SelectAllItem();

            Assert.AreEqual(beklenen, cardItem.Count);

        }

        [TestMethod]
        public void CardTestUpdate()
        {
           
            cardManager.UpdateCardItem(new ShopCardElement
            {
                Id = 1,
                count = 20,
                Name = "ürün"
            });
            var beklenen = 20;

            var cardItem = cardManager.SelectItem(1);


            Assert.AreEqual(beklenen, cardItem.count);

        }

        [ClassCleanup]
        public static void CardClear()
        {
            cardManager.DeleteCardItem(ShopCardElement);
        }

    }
}
