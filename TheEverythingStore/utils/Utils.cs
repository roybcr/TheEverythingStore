namespace TheEverythingStore.Helpers
{
    public static class Utils
    {
        private static readonly string KEY = "VEu4DRF1Wwgl54oI4TerpOTq";
        private static readonly string BASE_URL = "https://api.bestbuy.com/v1/products";
        private static readonly int DEFAULT_PAGE_SIZE = 50;
        private static readonly int DEFAULT_PAGE_NUMBER = 1;

        public static string BuildURL(UrlParams options)
        {
            // If show is true, request multiple products with only a few selected fields.
            bool show = options.show;
            // Path is needed when requesting a specific product and it should equal its SKU in the format '/xxxxxxx.json'. 
            string path = $"/{options.path}";
            // The amount of products to retreive at a single call.
            int pageSize = options.pageSize | DEFAULT_PAGE_SIZE;
            // Used for pagination purposes.
            int pageNumber = options.page | DEFAULT_PAGE_NUMBER;

            return show ?
            ($"{BASE_URL}?format=json&pageSize={pageSize}&page={pageNumber}&show=sku,name,salePrice,image,startDate&apiKey={KEY}") :
            ($"{BASE_URL}{path}.json?apiKey={KEY}");
        }
    }
}