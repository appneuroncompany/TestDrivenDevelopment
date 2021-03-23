using ShoppingCardSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCardSimulation.Concrete
{
    public class ShopCardElement : IEntity
    {
        public int Id { get; set; }
        public int count { get; set; }
        public string Name { get; set; }
    }
}
