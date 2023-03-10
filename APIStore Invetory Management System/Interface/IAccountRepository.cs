using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IAccountRepository
    {
        Task<Account?> Get(string userName, string password);

        Task<Account> Create(string username, string password, int employeeId);

        Task<Account?> Delete(int employeeId);
    }
}