using APIStore_Invetory_Management_System.Models;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IEmployeeRepository
    {
        Task<Employee?> Create(string firstNme, string lastName, string title);
        Task<Employee?> Get(int id);
        Task<Employee?> Delete(int employeeId);
    }
}