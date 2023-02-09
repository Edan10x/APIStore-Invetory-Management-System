using APIStore_Invetory_Management_System.Models;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IProductRepository
    {
        Task<Account?> Create(string username, string password, int employeeId);
        Task<Account?> Delete(int employeeId);
        Task<Account?> Get(string userName, string password);
    }
}