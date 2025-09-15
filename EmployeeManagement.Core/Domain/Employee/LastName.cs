using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Employee
{
    internal class LastName
    {
        public string Value{ get; }
        public LastName(string name)
        {
            if (String.IsNullOrWhiteSpace(name) || name.Length > 50)
            {
                throw new ArgumentException("Employee length is 1-50", nameof(name));
            }

            Value = name;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
