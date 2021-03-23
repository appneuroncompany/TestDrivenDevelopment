using ShoppingCardSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCardSimulation.Abstract
{
    public interface ICardService
    {
        void AddCardItem(ShopCardElement shopCardElement);
        void DeleteCardItem(ShopCardElement shopCardElement);
        void UpdateCardItem(ShopCardElement shopCardElement);
        List<ShopCardElement> SelectAllItem();
        ShopCardElement SelectItem(int id);

    }
}
