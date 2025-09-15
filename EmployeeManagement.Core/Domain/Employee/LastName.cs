using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Employee
{
    public class LastName
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

        // Equality

        public bool Equals(LastName? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj) => Equals(obj as LastName);

        public override int GetHashCode() =>
            Value.GetHashCode(StringComparison.OrdinalIgnoreCase);

        public static bool operator ==(LastName? left, LastName? right) =>
            Equals(left, right);

        public static bool operator !=(LastName? left, LastName? right) =>
            !Equals(left, right);

    }
}
