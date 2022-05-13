using Microsoft.AspNetCore.Mvc;
using TEST.API.Integration.Implementation;

namespace TEST.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }


        [HttpGet]
        public async Task<ActionResult> GetProduct()
        {
            var result = await _productservice.GetProduct();
            return Ok(result);
        }
    }
}