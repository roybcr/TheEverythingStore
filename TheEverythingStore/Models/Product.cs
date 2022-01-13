namespace TheEverythingStore.Models {

public record Product {

      public long Sku { get; init; }
      public string Name { get; init; }
      public double Price { get; init; }
      public string Image { get; init; }
      
   }
}