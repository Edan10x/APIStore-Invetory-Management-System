using APIStore_Invetory_Management_System.Models;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IStoreRepository
    {
        Task<Store?> Create(string storeLocation);
        Task<Store?> Delete(int id);
        Task<Store?> Get(int id);
    }
}