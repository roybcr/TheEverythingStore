using System.Collections.Generic;
using TheEverythingStore.Models;

namespace TheEverythingStore.Repositories {
   public interface IProductRepository {
      Product GetProduct(long Sku);
      IEnumerable<Product> GetProducts();
      void CreateProduct(Product product);
   }
}
