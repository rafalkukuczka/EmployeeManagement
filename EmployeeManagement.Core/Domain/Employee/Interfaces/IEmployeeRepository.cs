using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Employee.Interfaces
{
    public interface IEmployeeRepository
    {
        
        Task AddAsync(Employee employee);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee?> GetByEmployeeNumberAsync(EmployeeNumber employeeNumber);
        Task UpdateAsync(Employee employee);

    }
}
