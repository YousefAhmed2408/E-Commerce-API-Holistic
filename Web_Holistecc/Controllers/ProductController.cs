using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.Repository_s.ProductRepo_s;

namespace Web_Holistecc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("addProduct")]
        public IActionResult addProduct(ProductDTO dto)
        {
            _repo.addProduct(dto);
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
