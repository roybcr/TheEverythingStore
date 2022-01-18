using System.Collections.Generic;
using TheEverythingStore.Models;
using System.Threading.Tasks;


namespace TheEverythingStore.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Task<IEnumerable<Product>> GetProductsByName(string name);
    }
}
