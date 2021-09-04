using EmployeeInfoAPI.DataAccess;
using EmployeeInfoAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeeInfoAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDBContext _employeeDBContext;

        public EmployeeController(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }

        [HttpGet("GetEmployeeInfo")]
        public async Task<IActionResult> GetEmployeeInfo()
        {
            var employeeInfo = await _employeeDBContext.EmployeeInformation.ToListAsync();
            return Ok(employeeInfo);
        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployeeInfo([FromBody] EmployeeInfo employeeInfo)
        {
            await _employeeDBContext.EmployeeInformation.AddAsync(employeeInfo);
            await _employeeDBContext.SaveChangesAsync();
            return Ok(employeeInfo);
        }
    }
}