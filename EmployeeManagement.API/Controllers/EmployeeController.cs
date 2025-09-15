using Microsoft.AspNetCore.Mvc;

using EmployeeManagement.Core.Application;
using EmployeeManagement.Core.Domain.Employee;


namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeesController(EmployeeService service) {

            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Employee employee)
        {
            var createdEmployee = await _service.CreateEmployeeAsync(employee.LastName.Value, employee.Gender);

            return Ok(createdEmployee);
        }

        [HttpPut("{employeeNumber}")]
        public async Task<IActionResult> Update(int employeeNumber, [FromBody] Employee employee) {

            var updatedEmployee = await _service.UpdateEmployeeAsync(employeeNumber, employee.LastName.Value, employee.Gender);

            return Ok(updatedEmployee);
        }



    }
}
