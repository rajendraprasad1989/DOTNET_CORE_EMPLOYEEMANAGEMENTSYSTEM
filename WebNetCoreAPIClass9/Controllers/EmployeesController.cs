using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreAPIClass9.Data;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        #region " Variable "
        private readonly IEmployeeTestRepository _employeeTestRepository;
        #endregion

        #region " Constructor "
        public EmployeesController(IEmployeeTestRepository employeeTestRepository)
        {
            _employeeTestRepository = employeeTestRepository;
        }
        #endregion

        #region " Action Methods "
        /// <summary>
        /// //Retrieving Employee Details
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetEmployeesData")]
        public ActionResult<IEnumerable<EmployeeDetails>> GetEmployees()
        {
            var employee = _employeeTestRepository.GetEmployees().ToList();
            return employee;
        }

        /// <summary>
        /// //Retrieve Employee by employeeId
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("GetEmployeeById/{employeeId}")]
        public ActionResult<EmployeeDetails> GetEmployeeById(int employeeId)
        {
            EmployeeDetails employee = _employeeTestRepository.GetEmployeeById(employeeId);
            return Ok(employee);
        }

        /// <summary>
        /// //Adding Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost("AddEmployeeData")]
        public EmployeeDetails AddEmployee([FromBody]EmployeeDetails employeeDetails)
        {
            EmployeeDetails employee = _employeeTestRepository.AddEmployee(employeeDetails);
            return employee;
        }

        /// <summary>
        /// Updating Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPut("UpdateEmployeeData")]
        public ActionResult<EmployeeDetails> UpdateEmployee(int employeeId, [FromBody]EmployeeDetails employeeDetails)
        {
            var data = _employeeTestRepository.UpdateEmployee(employeeId,employeeDetails);
            if (data != null)
                return Ok(data);
            return NotFound();
        }

        /// <summary>
        /// //Deleting Employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpDelete("DeleteEmployeeData/{employeeId}")]
        public ActionResult<EmployeeDetails> DeleteEmployee(int employeeId)
        {
            var data =_employeeTestRepository.DeleteEmployee(employeeId);
            if (data != null)
                return Ok(data);
            return NotFound();
        }
        #endregion
    }
}