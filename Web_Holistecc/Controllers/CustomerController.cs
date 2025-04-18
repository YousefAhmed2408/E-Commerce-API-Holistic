using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Holistecc.DTO_s.CustomerDTO_s;
using Web_Holistecc.Repository_s.CustomerRepo_s;

namespace Web_Holistecc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;

        public CustomerController(ICustomerRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(CustomerDTOPost dto)
        {
               _repo.AddCustomer(dto);
            try
            {
               return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _repo.GetCustomer(id);
            try
            {
                return Ok(customer);
            }
            catch (Exception ex) 
            { 
                return NotFound(ex.Message);
            }
        }
    }
}
