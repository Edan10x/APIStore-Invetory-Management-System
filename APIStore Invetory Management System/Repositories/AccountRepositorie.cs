using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace APIStore_Invetory_Management_System.Repositories
{
    public class AccountRepositorie : IAccountRepositorie
    {
        private readonly SqlConnection _connection;

        public AccountRepositorie(SqlConnection connection)
        {
            _connection = connection;
        }


        public async Task<Account?> Get(string userName, string password)
        {
            var accounts = await _connection.QueryAsync<Account>($"SELECT * FROM [Account] WHERE Password = '{password}' and  UserName = '{userName}';");

            return accounts.FirstOrDefault();
        }

        public async Task<Account?> Create(string username, string password, int employeeId)
        {
            var accounts = await _connection.QueryAsync<Account>($"INSERT INTO [dbo].[Account] " +
                                                                 $"VALUES ('{username}', '{password}', '{employeeId}');");
            return accounts.FirstOrDefault();
        }

        public async Task<Account?> Delete(int employeeId)
        {
            var accounts = await _connection.QueryAsync($"DELETE FROM[Store_Invetory_Management].[dbo].[Employee]  WHERE Id = {employeeId};");

            return accounts.FirstOrDefault();
        }

    }
}
