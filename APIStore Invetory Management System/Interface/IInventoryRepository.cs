using APIStore_Invetory_Management_System.Models;
using APIStore_Invetory_Management_System.Request;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IInventoryRepository
    {
        Task<Inventory?> Create(int quantity, string aisle, int storeId, int productid);

        Task<Inventory?> Delete(int productId);
        Task<InventoryResponse?> Get(int id);
    }
}