namespace EmployeeManagement.Tests.Domain
{
    using Xunit;
    using Moq;
    using EmployeeManagement.Core.Domain.Employee;

    public class EmployeeTests
    {
        [Fact]
        public void Constructor_Should_Initialize_Properties()
        {
            // Arrange

            var employeeNumber = new EmployeeNumber(1);
            var lastName = new LastName("Kowalska");
            var gender = Gender.Female;

            // Act

            var employee = new Employee(employeeNumber, lastName, gender);

            // Assert

            Assert.NotEqual(Guid.Empty, employee.Id);
            Assert.Equal(employeeNumber, employee.EmployeeNumber);
            Assert.Equal(lastName, employee.LastName);
            Assert.Equal(gender, employee.Gender);


        }
    }
}
