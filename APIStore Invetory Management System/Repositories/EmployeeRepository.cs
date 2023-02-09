using APIStore_Invetory_Management_System.Interface;
using APIStore_Invetory_Management_System.Models;
using Dapper;
using System.Data.SqlClient;

namespace APIStore_Invetory_Management_System.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlConnection _connection;

        public EmployeeRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<Employee?>  Get(int id)
        {
            var employee = await _connection.QueryAsync<Employee>($"SELECT* FROM[dbo].[Employee] WHERE id = '{id}';");

            return employee.FirstOrDefault();
        }

        public async Task<Employee?> Create(string firstNme, string lastName, string title)
        {
            var employee = await _connection.QueryAsync<Employee>($"INSERT INTO [dbo].[Employee] " +
                                                                  $"VALUES ('{firstNme}', '{lastName}','{title}');");
            return employee.FirstOrDefault();
        }

        public async Task<Employee?> Delete(int employeeId)
        {
            var employee = await _connection.QueryAsync<Employee>($"DELETE FROM[Store_Invetory_Management].[dbo].[Employee]  WHERE Id = {employeeId};");

            return employee.FirstOrDefault();
        }



    }
}
