namespace TEST.API.Integration.Payload
{

    public class ProductConfig
    {
        public string publicKey { get; set; }
        public string baseUrl { get; set; }
    
    }


    public class AccessType
    {
        public const string PRODUCT_TEMPLATE = "/api/product.template/search?domain=[]&fields=[]";
    }
    
}