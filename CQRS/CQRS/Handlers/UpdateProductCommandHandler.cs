using CQRS.Commands;
using CQRS.Data;
using CQRS.Models;

namespace CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        public Product? Handle(UpdateProductCommand command)
        {
            var product = ProductStore.Products.FirstOrDefault(p => p.Id == command.Id);
            if (product != null)
            {
                product.Name = command.Name;
                product.Price = command.Price;
                product.Stock = command.Stock;
            }
            return product;
        }
    }
}
