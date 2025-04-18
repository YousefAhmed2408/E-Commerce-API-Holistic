using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.Repository_s.OrderRepo_s;

namespace Web_Holistecc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _repo;

        public OrderController(IOrderRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddOrder")]
        public IActionResult AddOrder(OrderPostDTO dto)
        {
            _repo.AddOrder(dto);
            try
            {
                 return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var s = _repo.GetAll();
            try
            {
                return Ok(s);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("DeleteOrder")]
        public IActionResult DeleteOrder(int id)
        {
           _repo.DeleteOrder(id);
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut("UpdateOrder")]
        public IActionResult UpdateOrder(OrderPutDTO dto, int id)
        {
            _repo.UpdateOrder(dto, id);
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
