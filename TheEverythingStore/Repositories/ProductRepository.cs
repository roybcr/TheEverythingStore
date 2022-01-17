using System;
using System.Linq;
using System.Collections.Generic;
using TheEverythingStore.Models;
using TheEverythingStore.Services;
using System.Threading.Tasks;

namespace TheEverythingStore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductService productService;
        private List<Product> products = new List<Product>();

        public ProductRepository(ProductService productService)
        {
            this.productService = productService;
            
            // Initialize the Product list with some data on init.
            this.fetchProducts().Wait();
        }


        private async Task<bool> fetchProducts()
        {
            this.products.AddRange(await this.productService.FetchProductsOnInit());
            return true;
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.products;
        }

        public Product GetProduct(long sku)
        {
            return products.Where(product => product.sku == sku).SingleOrDefault();
        }
    }
}
