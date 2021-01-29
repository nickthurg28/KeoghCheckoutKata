using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataTests
{
    public class TestFixtures
    {
        public Item itemA = new Item()
        {
            SKU = "A",
            UnitPrice = 10
        };
        public Item itemB = new Item()
        {
            SKU = "B",
            UnitPrice = 15
        };
        public Item itemD = new Item()
        {
            SKU = "D",
            UnitPrice = 55
        };
    }
}
