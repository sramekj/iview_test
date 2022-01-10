using System.Collections.Generic;
using System.Linq;
using server.Entities;

namespace server.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> ApplyDiscount(IEnumerable<Product> products, decimal discount)
        {
            var discountedProducts = products.Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price - p.Price * discount
            });
            return discountedProducts;
        }
    }
}