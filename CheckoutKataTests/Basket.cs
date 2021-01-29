using System;
using System.Collections.Generic;

namespace CheckoutKataTests
{
    public class Basket
    {
        private List<Item> _items = new List<Item>();

        public Basket()
        {
        }

        public void ScanItem(Item item)
        {
            _items.Add(item);
        }
    }
}