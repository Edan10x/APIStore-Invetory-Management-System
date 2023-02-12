using APIStore_Invetory_Management_System.Models;

namespace APIStore_Invetory_Management_System.Interface
{
    public interface IProductRepository
    {
        Task<Product?> Create(string name, int price);
        Task<Product?> Delete(int productId);
        Task<Product?> Get(int id);
    }
}