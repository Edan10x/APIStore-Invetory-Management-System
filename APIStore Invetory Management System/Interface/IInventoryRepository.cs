using APIStore_Invetory_Management_System.Models;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IInventoryRepository
    {
        Task<Inventory?> Create(int quantity, string aisle, int storeId, int productid);

        Task<Inventory?> Delete(int productId);
        Task<Inventory?> Get(int id);
    }
}