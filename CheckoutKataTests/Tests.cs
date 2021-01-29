using NUnit.Framework;

namespace CheckoutKataTests
{
    public class Tests
    {
        private Item itemA = new Item()
        {
            SKU = "A",
            UnitPrice = 10
        };
        private Item itemB = new Item() 
        {
            SKU = "B",
            UnitPrice = 15
        };
        private Item itemD = new Item() 
        {
            SKU = "D",
            UnitPrice = 55
        };

        private Basket basket = new Basket();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenAnItem_AddToBasket_BasketHasItem()
        {
            basket.ScanItem(itemA);

            Assert.IsNotNull(basket);
        }

        [Test]
        public void GivenItems_AddItemsToBasket_GetTotalPriceForItems()
        {
            basket.ScanItem(itemA);
            basket.ScanItem(itemB);

            Assert.AreEqual(basket.GetTotalPrice(), itemA.UnitPrice + itemB.UnitPrice);
        }

        [Test]
        public void GivenThreeItemB_AddToBasket_PromotionAdded()
        {
            basket.ScanItem(itemB, 3);

            Assert.AreEqual(basket.GetTotalPrice(), 40);
        }

        [Test]
        public void GivenTwoItemD_AddToBasket_25PercentOff()
        {
            basket.ScanItem(itemD, 2);

            Assert.AreEqual(basket.GetTotalPrice(), 82);
        }
    }
}