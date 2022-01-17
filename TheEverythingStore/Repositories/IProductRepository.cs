using System.Collections.Generic;
using TheEverythingStore.Models;
namespace TheEverythingStore.Repositories
{
    public interface IProductRepository
    {
        Product GetProduct(long sku);
        IEnumerable<Product> GetProducts();
    }
}
