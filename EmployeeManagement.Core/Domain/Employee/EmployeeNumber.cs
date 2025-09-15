namespace EmployeeManagement.Core.Domain.Employee
{
    public class EmployeeNumber 
    {
        public string Value { get; }
        public EmployeeNumber(int no)
        {
            if (no<0 || no > 99999999)
            {
                throw new ArgumentException("Employee number range is 0-99999999", nameof(no));
            }

            Value = no.ToString("D8");

        }

        public override string ToString()
        {
            return Value;
        }

    }
}
