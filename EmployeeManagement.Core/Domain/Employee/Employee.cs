using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Employee
{
    public class Employee
    {
        public Guid Id { get; }

        public EmployeeNumber EmployeeNumber { get; private set; }
        public LastName LastName { get; private set; } 
        public Gender Gender { get; private set; }

        public Employee(EmployeeNumber employeeNumber, LastName lastName, Gender gender)
        {
            Id = Guid.NewGuid();
            EmployeeNumber = employeeNumber ?? throw new ArgumentNullException(nameof(employeeNumber));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Gender = gender;
        }

        public void Update(LastName lastName, Gender gender)
        {
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Gender = gender;
        }


    }
}
