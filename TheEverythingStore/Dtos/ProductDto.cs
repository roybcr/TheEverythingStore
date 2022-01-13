using System.ComponentModel.DataAnnotations;

namespace TheEverythingStore.Dtos {

   public record ProductDto {

      [Required]
      public long Sku { get; init; }
      
      [Required]
      public string Name { get; init; }
      
      [Required]
      [Range(1, double.MaxValue)]
      public double Price { get; init; }

      [Required]
      [Url]
      public string Image { get; init; }
   
   }

}
