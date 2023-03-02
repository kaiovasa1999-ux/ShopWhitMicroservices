namespace Shop.Data.Models
{
    public class Dealer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<ItemAd> ItemsAds { get; set; } = new List<ItemAd>();

    }
}