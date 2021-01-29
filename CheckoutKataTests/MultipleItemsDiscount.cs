using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataTests
{
    public class MultipleItemsDiscount
    {
        public Dictionary<string, Promotion> Promotions
        {
            get
            {
                return new Dictionary<string, Promotion>
                {
                    { "B", new Promotion(3, 40) },
                    { "D", new Promotion(2, 82)}
                };
            }
        }
        public Dictionary<string, int> NormalPrice
        {
            get
            {
                return new Dictionary<string, int>
                {
                    { "A", 10 },
                    { "B", 15 }
                };
            }
        }
    }
}
