using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Repositories;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace APIStore_Invetory_Management_System.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountRepositorie _repositorie;
       
        public AccountController(IAccountRepositorie repositorie)
        {
            _repositorie = repositorie;
        }

        [HttpGet(Name = "GetAccounts")]
        public async Task<Account?> Get(string username, string password)
        {
            var account = await _repositorie.Get(username, password);
            return account;
        }

        [HttpPost(Name = "CreateAccount")]
        public async Task<IActionResult?> Create([FromBody] CreateAccountRequest request)
        {

            await _repositorie.Create(request.Username, request.Password, request.EmployeeId);
            return Ok();
        }

       

    }
}
