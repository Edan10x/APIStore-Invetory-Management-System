using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace APIStore_Invetory_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : Controller
    {
        private readonly IInventoryRepository _repositorie;

        public InventoryController(IInventoryRepository repositorie)
        {
            _repositorie = repositorie;
        }

        [HttpGet(Name = "GetInventory")]
        public async Task<Inventory?> Get(int id)
        {
            var inventory = await _repositorie.Get(id);
            return inventory;
        }

        [HttpPost(Name = "CreateInventory")]
        public async Task<IActionResult?> Create([FromBody] CreateInventoryRequest request)
        {

            var inventory = await _repositorie.Create(request.Quantity, request.Aisle, request.StoreId, request.ProductId);
            return Ok();
        }

        [HttpDelete(Name = "DeleteInventory")]
        public async Task<IActionResult?> Delete([FromBody] int productId)
        {

            var inventory = await _repositorie.Delete(productId);
            return Ok();
        }

    }
}
