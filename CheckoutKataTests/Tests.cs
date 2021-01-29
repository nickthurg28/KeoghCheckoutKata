using NUnit.Framework;

namespace CheckoutKataTests
{
    public class Tests
    {
        private Basket basket = new Basket();

        private TestFixtures testFixtures = new TestFixtures();

        [Test]
        public void GivenAnItem_AddToBasket_BasketHasItem()
        {
            basket.ScanItem(testFixtures.itemA);

            Assert.IsNotNull(basket);
        }

        [Test]
        public void GivenItems_AddItemsToBasket_GetTotalPriceForItems()
        {
            basket.ScanItem(testFixtures.itemA);
            basket.ScanItem(testFixtures.itemB);

            Assert.AreEqual(basket.GetTotalPrice(), testFixtures.itemA.UnitPrice + testFixtures.itemB.UnitPrice);
        }

        [Test]
        public void GivenThreeItemB_AddToBasket_PromotionAdded()
        {
            basket.ScanItem(testFixtures.itemB, 3);

            Assert.AreEqual(basket.GetTotalPrice(), 40);
        }

        [Test]
        public void GivenTwoItemD_AddToBasket_25PercentOff()
        {
            basket.ScanItem(testFixtures.itemD, 2);

            Assert.AreEqual(basket.GetTotalPrice(), 82);
        }
    }
}