using ShoppingCardSimulation.Abstract;
using ShoppingCardSimulation.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCardSimulation.Concrete
{
    public class CardManager : ICardService
    {
        IShopCardDal<ShopCardElement> _shopCardDal;
        public CardManager(IShopCardDal<ShopCardElement> shopCardDal)
        {
            _shopCardDal = shopCardDal;
        }

        public void AddCardItem(ShopCardElement shopCardElement)
        {
            _shopCardDal.Add(shopCardElement);
        }

        public void DeleteCardItem(ShopCardElement shopCardElement)
        {
            _shopCardDal.Delete(shopCardElement);
        }

        public List<ShopCardElement> SelectAllItem()
        {
           return _shopCardDal.SelectAll();
        }

        public ShopCardElement SelectItem(int id)
        {
            return _shopCardDal.Select(id);
        }

        public void UpdateCardItem(ShopCardElement shopCardElement)
        {
            _shopCardDal.Update(shopCardElement);
        }
    }
}
