namespace Shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descirption { get; set; }

        public IEnumerable<ItemAd> Items { get; set; } = new List<ItemAd>();

    }
}