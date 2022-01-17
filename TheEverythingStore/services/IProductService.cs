using System;
using System.Collections.Generic;
using TheEverythingStore.Models;
using System.Threading.Tasks;

namespace TheEverythingStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> FetchProductsOnInit();
    }
}
