using System;
using System.Collections.Generic;

namespace CheckoutKataTests
{
    public class Basket
    {
        private List<Item> _items = new List<Item>();

        private int _basketTotal = 0;

        public Basket()
        {
        }

        public void ScanItem(Item item)
        {
            _items.Add(item);
        }

        public void ScanItem(Item item, int quantityofItem)
        {
            var promotionItems = new MultipleItemsDiscount().Promotions[item.SKU];

            if (promotionItems != null && promotionItems.NumberOfItems == quantityofItem)
                _basketTotal += promotionItems.Discount;
            else
                _basketTotal += new MultipleItemsDiscount().NormalPrice[item.SKU];
        }

        public int GetTotalPrice()
        {
            return _basketTotal;
        }
    }
}