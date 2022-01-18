using System;
using System.Collections.Generic;

namespace TheEverythingStore.Models
{
    public class Product
    {
        public int sku { get; init; }
        public string name { get; init; }
        public double salePrice { get; init; }
        public string image { get; init; }

    }
}