namespace TheEverythingStore.Helpers
{
    public static class Utils
    {
        private static readonly string KEY = "VEu4DRF1Wwgl54oI4TerpOTq";
        private static readonly string BASE_URL = "https://api.bestbuy.com/v1/products";

        public static string BuildURL(UrlParams options)
        {
            // If show is true, request multiple products with only a few selected fields.
            string name = options.name;
            // The amount of products to retreive at a single call.
            int pageSize = options.pageSize;
            // Used for pagination purposes.
            int pageNumber = options.page;

            return name is null ?
            ($"{BASE_URL}?format=json&pageSize={pageSize}&page={pageNumber}&show=sku,name,salePrice,image&apiKey={KEY}") :
            ($"{BASE_URL}(name={name}*)?format=json&pageSize={pageSize}&page={pageNumber}&show=sku,name,salePrice,image&apiKey={KEY}");
        }
    }
}