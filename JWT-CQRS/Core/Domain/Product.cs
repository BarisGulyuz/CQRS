namespace JWT_CQRS.Core.Domain
{
    public class Product
    {
        public Product()
        {
            Category = new Category();
        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
