using NUnit.Framework;

namespace CheckoutKataTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenAnItem_AddToBasket_BasketHasItem()
        {
            var item = new Item()
            { 
                SKU = "A",
                UnitPrice = 10
            };

            var basket = new Basket();
            basket.ScanItem(item);

            Assert.IsNotNull(basket);
        }
    }
}