namespace Shop.Data.Models
{
    public class ItemAd
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool IsAvaiable { get; set; }

        public int Quantity { get; set; }

        public int DealerId { get; set; }

        public Dealer Dealer { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
