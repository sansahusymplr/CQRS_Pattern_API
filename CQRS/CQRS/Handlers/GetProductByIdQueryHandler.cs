using CQRS.Data;
using CQRS.Models;
using CQRS.Queries;

namespace CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        public Product? Handle(GetProductByIdQuery query)
        {
            return ProductStore.Products.FirstOrDefault(p => p.Id == query.Id);
        }
    }
}
