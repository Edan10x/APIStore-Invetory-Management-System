using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using Dapper;
using System.Data.SqlClient;

namespace APIStore_Invetory_Management_System.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {

        private readonly SqlConnection _connection;

        public InventoryRepository(SqlConnection connection)
        {
            _connection = connection;
        }


        public async Task<Inventory?> Get(int id)
        {
            var inventory = await _connection.QueryAsync<Inventory>($"SELECT * FROM [dbo].[Inventory] WHERE ProductId = {id};");

            return inventory.FirstOrDefault();
        }

        public async Task<Inventory?> Create(int quantity, string aisle, int storeId, int productId)
        {
            var inventory = await _connection.QueryAsync<Inventory>($"INSERT INTO [dbo].[Inventory] " +
                                                                    $"VALUES ({quantity}, '{aisle}', {storeId}, {productId});");
            return inventory.FirstOrDefault();
        }

        public async Task<Inventory?> Delete(int productId)
        {
            var products = await _connection.QueryAsync($"DELETE FROM[Store_Invetory_Management].[dbo].[Inventory] WHERE ProductId = {productId};");

            return products.FirstOrDefault();
        }
    }
}
