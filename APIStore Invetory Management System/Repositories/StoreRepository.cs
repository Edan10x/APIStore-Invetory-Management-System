using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using Dapper;
using System.Data.SqlClient;

namespace APIStore_Invetory_Management_System.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly SqlConnection _connection;

        public StoreRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<Store?> Get(int id)
        {
            var store = await _connection.QueryAsync<Store>($"SELECT * FROM [dbo].[Store] WHERE id = {id};");

            return store.FirstOrDefault();
        }

        public async Task<Store?> Create(string storeLocation)
        {
            var store = await _connection.QueryAsync<Store>($"INSERT INTO [dbo].[Store]VALUES('{storeLocation}');");
            return store.FirstOrDefault();
        }

        public async Task<Store?> Delete(int id)
        {
            var store = await _connection.QueryAsync<Store>($"DELETE FROM[Store_Invetory_Management].[dbo].[Store] WHERE id = {id};");

            return store.FirstOrDefault();
        }
    }
}
