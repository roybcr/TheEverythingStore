using System;
using System.Collections.Generic;
using TheEverythingStore.Models;
using System.Threading.Tasks;
using TheEverythingStore.Helpers;

namespace TheEverythingStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> FetchProducts(UrlParams options);
    }
}
