namespace VehiclePortal.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        // Foreign Key to Listing (The item sold)
        public int ListingId { get; set; }
        public Listing Listing { get; set; }

        // Foreign Key to Buyer
        public int BuyerId { get; set; }
        public User Buyer { get; set; }
    }
}
