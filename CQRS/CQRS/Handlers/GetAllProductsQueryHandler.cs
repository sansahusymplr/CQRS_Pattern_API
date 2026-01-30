using CQRS.Data;
using CQRS.Models;
using CQRS.Queries;

namespace CQRS.Handlers
{
    public class GetAllProductsQueryHandler
    {
        public List<Product> Handle(GetAllProductsQuery query)
        {
            return ProductStore.Products;
        }
    }
}
