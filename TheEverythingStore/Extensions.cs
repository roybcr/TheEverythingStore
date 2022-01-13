using TheEverythingStore.Dtos;
using TheEverythingStore.Models;

namespace TheEverythingStore {

   public static class Extensions {
      public static ProductDto AsProductDto(this Product p) {

         return new ProductDto() {
            
            Sku   = p.Sku,
            Name  = p.Name,
            Price = p.Price,   
            Image = p.Image,
         
         };
      
      }

      public static Product New(this Product p) {
         
         return new Product() {

            Sku   = p.Sku,
            Name  = p.Name,
            Price = p.Price,
            Image = p.Image,
         
         };

      }
   
   }

}
