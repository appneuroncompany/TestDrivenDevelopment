using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCardSimulation.Abstract
{
    public interface IShopCardDal<T>
        where T: IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> SelectAll();
        T Select(int id);

    }
}
