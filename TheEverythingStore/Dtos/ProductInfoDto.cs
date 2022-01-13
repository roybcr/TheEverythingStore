using System;
using System.Collections.Generic;
using TheEverythingStore.Models;

namespace TheEverythingStore.Dtos {

   public record ProductInfoDto: Product {
      public bool New {
         get;
         init;
      }

      public bool Active {
         get;
         init;
      }

      public bool OnSale {
         get;
         init;
      }

      public double SalePrice {
         get;
         init;
      }

      public string URL {
         get;
         init;
      }

      public string Slot {
         get;
         init;
      }

      public IEnumerable<string> images {
         get;
         init;
      }

   }
}
