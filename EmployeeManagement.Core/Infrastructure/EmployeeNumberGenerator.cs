using EmployeeManagement.Core.Domain.Employee;
using EmployeeManagement.Core.Domain.Employee.Interfaces;
using System.Linq;

namespace EmployeeManagement.Core.Infrastructure
{
    internal class EmployeeNumberGenerator : IEmployeeNumberGenerator
    {
        public EmployeeNumber NextNumber(IEnumerable<Employee> employees)
        {
            int max = employees.Max(e=> int.Parse(e.EmployeeNumber.Value));

            return new EmployeeNumber(max + 1); 
        }
    }
}
