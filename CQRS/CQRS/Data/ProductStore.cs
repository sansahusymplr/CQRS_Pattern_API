using CQRS.Models;

namespace CQRS.Data
{
    public static class ProductStore
    {
        private static List<Product> _products = GenerateTestData();

        public static List<Product> Products => _products;

        private static List<Product> GenerateTestData()
        {
            var products = new List<Product>();
            var random = new Random(42);
            var categories = new[] { "Electronics", "Clothing", "Books", "Food", "Toys", "Sports", "Home", "Garden", "Tools", "Beauty" };
            var items = new[] { "Pro", "Ultra", "Max", "Plus", "Lite", "Premium", "Standard", "Basic", "Deluxe", "Classic" };

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"{categories[random.Next(categories.Length)]} {items[random.Next(items.Length)]} {i}",
                    Price = Math.Round((decimal)(random.NextDouble() * 1000 + 10), 2),
                    Stock = random.Next(0, 500)
                });
            }

            return products;
        }
    }
}
