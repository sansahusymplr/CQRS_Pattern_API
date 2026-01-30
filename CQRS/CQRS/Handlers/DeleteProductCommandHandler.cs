using CQRS.Commands;
using CQRS.Data;

namespace CQRS.Handlers
{
    public class DeleteProductCommandHandler
    {
        public bool Handle(DeleteProductCommand command)
        {
            var product = ProductStore.Products.FirstOrDefault(p => p.Id == command.Id);
            if (product != null)
            {
                ProductStore.Products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
