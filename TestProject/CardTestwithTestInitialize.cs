using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCardSimulation.Concrete;
using ShoppingCardSimulation.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class CardTestwithTestInitialize
    {
        CardManager cardManager = new CardManager(new InMemoryCardDal());
        ShopCardElement ShopCardElement = new ShopCardElement
        {
            Id = 1,
            count = 15,
            Name = "ürün"
        };

        [TestInitialize]
        public void CardTestInitialize()
        {
            cardManager.AddCardItem(ShopCardElement);
        }

        [TestMethod]
        public void CardTestCount()
        {

            var beklenen = 1;

            var cardItem =cardManager.SelectAllItem();

            Assert.AreEqual(beklenen, cardItem.Count);

        }

        [TestCleanup]
        public void CardClear()
        {
            cardManager.DeleteCardItem(ShopCardElement);
        }

    }
}
