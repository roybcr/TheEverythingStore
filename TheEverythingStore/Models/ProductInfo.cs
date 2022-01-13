using System;
using System.Collections.Generic;

namespace TheEverythingStore.Models {

   public record ProductInfo: Product {

      public bool New { get; init; }

      public bool Active { get; init; }
      
      public bool OnSale { get; init; }
      
      public double SalePrice { get; init; }
      
      public string URL { get; init; }
      
      public string Slot { get; init; }
      
      public List<string> images { get; init; }

   }

}