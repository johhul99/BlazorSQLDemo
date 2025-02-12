using BlazorSQLDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSQLDemo.Data
{
    public class EmployeeService
    {
        private readonly EmployeeDbContext _Context;

        public EmployeeService(EmployeeDbContext context)
        {
            _Context = context;
        }

        public async Task AddEmployee(Employee employee)
        {
            try
            {
                _Context.Employees.Add(employee);
                await _Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<List<Employee>> GetEmployees()
        {

            return await _Context.Employees.ToListAsync();
        }
    }
}
