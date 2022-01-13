using System;
using System.Collections.Generic;


namespace TheEverythingStore.Dtos {

   public record PaginatedProductsDto {

      public int From {
         get;
         init;
      }

      public int To {
         get;
         init;
      }

      public int CurrentPage {
         get;
         init;
      }

      public int TotalPages {
         get;
         init;
      }

      public int Total {
         get;
         init;
      }

      public string ShortDescriptionHtml {
         get;
         init;
      }

      public IEnumerable<ProductDto> products {
         get;
         init;
      }

   }
}