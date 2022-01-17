using TheEverythingStore.Dtos;
using TheEverythingStore.Models;

namespace TheEverythingStore
{
    public static class Extensions
    {
        public static ProductDto AsProductDto(this Product p)
        {
            return new ProductDto()
            {
                sku = p.sku,
                name = p.name,
                salePrice = p.salePrice,
                image = p.image,
            };
        }

        public static Product New(this Product p)
        {
            return new Product()
            {
                sku = p.sku,
                name = p.name,
                salePrice = p.salePrice,
                image = p.image,
            };
        }
    }
}
