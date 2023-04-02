using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveUpAPI.DTO;
using SaveUpAPI.Services;

namespace SaveUpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataManagmentController : ControllerBase
    {
        private readonly IDataManagmentService _DataManagment;

        public DataManagmentController(IDataManagmentService dataManagment)
        {
            _DataManagment = dataManagment;
        }

        [HttpGet]
        public List<SaveUpDTO> GetAllProducts() 
        {
            return _DataManagment.GetAllProducts();
        }

        [HttpPost]
        public void PostNewAuftrag(SaveUpPostDTO Data)
        {
            _DataManagment.PostNewProduct(Data);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSelectedProduct(Guid id)
        {
            if (_DataManagment == null)
            { return NotFound(); }

            if (_DataManagment.GetProductById(id) == null)
            { return BadRequest(); }
            else
            {
                _DataManagment.DeleteSelectedProduct(id);
                return Ok();
            }

        }

        [HttpDelete]
        public ActionResult DeleteAllProducts()
        {
            if (_DataManagment == null)
            { return NotFound(); }
            else
            {
                _DataManagment.DeleteAllProducts();
                return Ok();
            }

        }
    }
}
