namespace CheckoutKataTests
{
    public class Promotion
    {
        public Promotion(int numberOfItems, int discount)
        {
            NumberOfItems = numberOfItems;
            Discount = discount;
        }

        public int NumberOfItems { get; set; }
        public int Discount { get; set; }
    }
}