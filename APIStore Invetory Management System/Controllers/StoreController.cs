using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace APIStore_Invetory_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : Controller
    {
        private readonly IStoreRepository _repositorie;

        public StoreController(IStoreRepository repositorie)
        {
            _repositorie = repositorie;
        }

        [HttpGet(Name = "GetStore")]
        public async Task<Store?> Get(int id)
        {
            var store = await _repositorie.Get(id);
            return store;
        }

        [HttpPost(Name = "CreateStore")]
        public async Task<IActionResult?> Create([FromBody] CreateStoreRequestcs request)
        {

            var store = await _repositorie.Create(request.StoreLocation);
            return Ok();
        }

        [HttpDelete(Name = "DeleteStroe")]
        public async Task<IActionResult?> Delete([FromBody] int id)
        {

            var store = await _repositorie.Delete(id);
            return Ok();
        }
    }
}
