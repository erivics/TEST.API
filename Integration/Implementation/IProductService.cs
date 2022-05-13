using TEST.API.Integration.ProductResponsePayLoad;

namespace TEST.API.Integration.Implementation
{
    public interface IProductService
    {
        Task <ProductResponse> GetProduct();

    }
}