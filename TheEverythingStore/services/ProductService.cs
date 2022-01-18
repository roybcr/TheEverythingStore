using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using TheEverythingStore.Dtos;
using TheEverythingStore.Helpers;
using TheEverythingStore.Models;

namespace TheEverythingStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory httpClient = null!;

        public ProductService(IHttpClientFactory httpClientFactory) => (this.httpClient) = (
            httpClientFactory
        );

        public async Task<IEnumerable<Product>> FetchProducts(UrlParams options)
        {
            // Creating the HTTP Client.
            HttpClient client = this.httpClient.CreateClient();
            try
            {
                // Helper method to customize the request URL according to our needs.
                string url = Helpers.Utils.BuildURL(options);
                // Make HTTP Get Request & Parse JSON response into PaginatedProductsDto type.
                PaginatedProductsDto result = await client.GetFromJsonAsync<PaginatedProductsDto>(url);

                if (result is not null)
                {
                    IEnumerable<Product> incomingProducts = result.products.Select((p) =>
                    {
                        return new Product()
                        {
                            sku = p.sku,
                            name = p.name,
                            salePrice = p.salePrice,
                            image = p.image,
                        };
                    });

                    return incomingProducts.ToList();
                }
                else { throw new Exception("Something went wrong."); }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
