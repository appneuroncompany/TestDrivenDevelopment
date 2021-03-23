using ShoppingCardSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingCardSimulation.Concrete.InMemory
{
    public class InMemoryCardDal : IShopCardDal<ShopCardElement>
    {
        List<ShopCardElement> _entities;

        public InMemoryCardDal()
        {
            _entities = new List<ShopCardElement>();
        }

        public void Add(ShopCardElement entity)
        {
            _entities.Add(entity);
        }

        public void Delete(ShopCardElement entity)
        {
            var item = _entities.SingleOrDefault(e => e.Id == entity.Id);
            _entities.Remove(item);
        }

        public ShopCardElement Select(int id)
        {
            var item = _entities.SingleOrDefault(e => e.Id == id);
            return item;

        }

        public List<ShopCardElement> SelectAll()
        {
            return _entities;
        }

        public void Update(ShopCardElement entity)
        {
            var item = _entities.SingleOrDefault(e => e.Id == entity.Id);
            item.Name = entity.Name;
            item.count = entity.count;
        }
    }
}
