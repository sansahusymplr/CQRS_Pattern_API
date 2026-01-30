using CQRS.Commands;
using CQRS.Data;
using CQRS.Models;

namespace CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        public Product Handle(CreateProductCommand command)
        {
            var product = new Product
            {
                Id = ProductStore.Products.Max(p => p.Id) + 1,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock
            };
            ProductStore.Products.Add(product);
            return product;
        }
    }
}
