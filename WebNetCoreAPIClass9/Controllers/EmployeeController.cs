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
    public class EmployeeController : ControllerBase
    {
        #region " Variables "
        private readonly IEmployeeRepository _employeeRepository;
        #endregion

        #region " Constructor "
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region " Action Methods "
        /// <summary>
        /// //Retrieving Employee Details
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetEmployeesData")]
        public ActionResult<List<Employee>> GetEmployees()
        {
            //List<EmployeeDetails> employeesList = new List<EmployeeDetails>();
            var employeesList = _employeeRepository.GetEmployees();
            if (employeesList == null) return NotFound();
            return Ok(employeesList);
        }

        /// <summary>
        /// //Retrieve Employee by employeeId
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("GetEmployeeById/{employeeId}")]
        public ActionResult<Employee> GetEmployeeById(int employeeId)
        {
            var data = _employeeRepository.GetEmployeeById(employeeId);
            if (data == null) return NotFound();
            return data;
        }

        /// <summary>
        /// //Adding Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost("AddEmployeeData")]
        public Employee AddEmployee([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee addEmployees = _employeeRepository.AddEmployee(employee);
                return addEmployees;
            }
            return null;
        }

        /// <summary>
        /// Updating Employee Details
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPut("UpdateEmployeeData")]
        public Employee UpdateEmployee([FromBody] Employee employee)
        {
            Employee updateEmployee =_employeeRepository.UpdateEmployee(employee);
            if (updateEmployee != null)
            {
                return updateEmployee; 
            }
            return null;
        }

        /// <summary>
        /// //Deleting Employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpDelete("DeleteEmployeeData/{employeeId}")]
        public ActionResult<Employee> DeleteEmployee(int employeeId)
        {
            Employee deleteData = _employeeRepository.DeleteEmployee(employeeId);
            if (deleteData != null)
            {
                return Ok(deleteData);
            }
            return null;
        }
        #endregion
    }
}