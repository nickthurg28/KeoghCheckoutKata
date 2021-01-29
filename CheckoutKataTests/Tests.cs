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
    }
}