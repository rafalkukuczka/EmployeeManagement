using EmployeeManagement.Core.Domain.Employee;
using EmployeeManagement.Core.Domain.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Application
{
    internal class EmployeeService
    {
        private IEmployeeRepository _repository;
        private IEmployeeNumberGenerator _generator;

        public EmployeeService(IEmployeeRepository repository, IEmployeeNumberGenerator generator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _generator = generator ?? throw new ArgumentNullException(nameof(generator));
        }

        public async Task<Employee> CreateEmployeeAsync(string lastName, Gender gender)
        {
            var existingEmployees = await _repository.GetAllAsync();
            var newEmployeeNumber = _generator.NextNumber(existingEmployees);

            var employee = new Employee(newEmployeeNumber, new LastName(lastName), gender);
            await _repository.AddAsync(employee);

            return employee;

        }

        public async Task<Employee> UpdateEmployeeAsync(Guid id, string lastName, Gender gender)
        {
            var employee = await _repository.GetByIdAsync(id);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found", nameof(id));
            }

            employee.Update(new LastName(lastName), gender);

            await _repository.UpdateAsync(employee);

            return employee;

        }
    }
}
