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
        public async Task<Product?> Get(int id)
        {
            var product = await _repositorie.Get(id);
            return product;
        }

        [HttpPost(Name = "CreateProduct")]
        public async Task<IActionResult?> Create([FromBody] CreateProductRequestcs request)
        {

            var product = await _repositorie.Create(request.name, request.price);
            return Ok();
        }

        [HttpDelete(Name = "DeleteProduct")]
        public async Task<IActionResult?> Delete([FromBody] int productId)
        {

            var product = await _repositorie.Delete(productId);
            return Ok();
        }
    }
}
