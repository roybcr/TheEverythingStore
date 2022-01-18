using System.ComponentModel.DataAnnotations;

namespace TheEverythingStore.Helpers
{
    public record UrlParams
    {
        public string path { get; init; }
        public int page { get; init; }
        public int pageSize { get; init; }
        public string name { get; set; }
    }
}