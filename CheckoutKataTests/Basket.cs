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

        public int GetTotalPrice()
        {
            var basketTotal = 0;

            foreach (var item in _items)
            {
                basketTotal = basketTotal + item.UnitPrice;
            }

            return basketTotal;
        }
    }
}