using System;
using System.Collections.Generic;
using TheEverythingStore.Models;
using TheEverythingStore.Services;
using System.Threading.Tasks;
using TheEverythingStore.Helpers;

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
            this.initialize().Wait();
        }


        private async Task<bool> initialize()
        {
            UrlParams options = new UrlParams() { page = 1, pageSize = 50 };
            this.products.AddRange(await this.productService.FetchProducts(options));
            return true;
        }

        public IEnumerable<Product> GetProducts()
        {
            System.Console.WriteLine(" --------------- Getting Products ----------------");
            return this.products;
        }

        public async Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            UrlParams options = new UrlParams() { page = 1, pageSize = 5, name = name };
            this.products.AddRange(await this.productService.FetchProducts(options));
            return this.products;
        }
    }
}
