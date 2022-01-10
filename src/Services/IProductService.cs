using System.Collections.Generic;
using server.Entities;

namespace server.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> ApplyDiscount(IEnumerable<Product> products, decimal discount);
    }
}