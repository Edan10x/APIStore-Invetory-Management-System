using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace APIStore_Invetory_Management_System.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _repositorie;

        public EmployeeController(IEmployeeRepository repositorie)
        {
            _repositorie = repositorie;
        }

        [HttpGet(Name = "GetEmployee")]
        public async Task<Employee?> Get(int id)
        {
            var employee = await _repositorie.Get(id);
            return employee;
        }

        [HttpPost(Name = "CreateEmployee")]
        public async Task<IActionResult?> Create([FromBody] CreateEmployeeRequest request)
        {

            var employee = await _repositorie.Create(request.FirstNme, request.LastName, request.Title);
            return Ok();
        }

        [HttpDelete(Name = "DeleteEmployee")]
        public async Task<IActionResult?> Delete([FromBody] int employeeId)
        {

            var employee = await _repositorie.Delete(employeeId);
            return Ok();
        }
    }
}
