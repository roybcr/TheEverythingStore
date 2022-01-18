using System;
using System.Collections.Generic;
using TheEverythingStore.Models;

namespace TheEverythingStore.Dtos
{
    public record PaginatedProductsDto
    {
        public int from { get; init; }
        public int to { get; init; }
        public int currentPage { get; init; }
        public int totalPage { get; init; }
        public int total { get; init; }
        public string shortDescriptionHTML { get; init; }
        public IEnumerable<Product> products { get; init; }
    }
}