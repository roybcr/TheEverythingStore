using System.ComponentModel.DataAnnotations;

namespace TheEverythingStore.Dtos
{
    public record ProductDto
    {
        [Required]
        public long sku { get; init; }

        [Required]
        public string name { get; init; }

        [Required]
        [Range(1, double.MaxValue)]
        public double salePrice { get; init; }

        [Required]
        [Url]
        public string image { get; init; }
    }
}
