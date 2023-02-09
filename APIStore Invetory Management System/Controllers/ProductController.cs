using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace APIStore_Invetory_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller 
    {
        private readonly IProductRepository _repositorie;

        public ProductController(IProductRepository repositorie)
        {
            _repositorie = repositorie;
        }

        [HttpGet(Name = "GetProduct")]
        public async Task<Store?> Get(int id)
        {
            var product = await _repositorie.Get(id);
            return product;
        }

        [HttpPost(Name = "CreateProduct")]
        public async Task<IActionResult?> Create([FromBody] CreateStoreRequestcs request)
        {

            var product = await _repositorie.Create(request.StoreLocation);
            return Ok();
        }

        [HttpDelete(Name = "DeleteProduct")]
        public async Task<IActionResult?> Delete([FromBody] int id)
        {

            var product = await _repositorie.Delete(id);
            return Ok();
        }
    }
}
