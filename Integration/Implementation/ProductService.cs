using System.Net.Http.Headers;
using Microsoft.Extensions.Options;
using TEST.API.Integration.Payload;
using System.Text.Json;
using TEST.API.Integration.ProductResponsePayLoad;
using System.Text;

namespace TEST.API.Integration.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ProductConfig _config;
        private readonly HttpClient client = new HttpClient();

        public ProductService(IOptions<ProductConfig> config)
        {
            _config = config.Value;

            client.BaseAddress = new Uri(_config.baseUrl);
            client.DefaultRequestHeaders.Add("api-key", _config.publicKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonp"));
        
        }
        
        
        public async Task<ProductResponse> GetProduct()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(AccessType.PRODUCT_TEMPLATE);
                var resultData = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ProductResponse>(resultData);
                return result;

            }
            catch (Exception ex)
            {
                
                return new ProductResponse
                {
                    message = ex.Message
                };
            }
        
        }

        
    }
}