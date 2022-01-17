using System.ComponentModel.DataAnnotations;

namespace TheEverythingStore.Helpers
{
    public record UrlParams
    {
        [Required]
        public bool show { get; init; }
        public string path { get; init; }
        public int page { get; init; }
        public int pageSize { get; init; }
    }
}