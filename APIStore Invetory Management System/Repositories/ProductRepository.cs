using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using Dapper;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace APIStore_Invetory_Management_System.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlConnection _connection;

        public ProductRepository(SqlConnection connection)
        {
            _connection = connection;
        }


        public async Task<Product?> Get(int id)
        {
            var products = await _connection.QueryAsync<Product>($"SELECT * FROM [dbo].[Product] WHERE id = {id};");

            return products.FirstOrDefault();
        }

        public async Task<Product?> Create(string name, double price)
        {
            var products = await _connection.QueryAsync<Product>($"INSERT INTO [dbo].[Product] VALUES ('{name}', '{price}');");
            return products.FirstOrDefault();
        }

        public async Task<Product?> Delete(int productId)
        {
            var products = await _connection.QueryAsync($"DELETE FROM[Store_Invetory_Management].[dbo].[Product]  WHERE Id = {productId};");

            return products.FirstOrDefault();
        }
    }
}
