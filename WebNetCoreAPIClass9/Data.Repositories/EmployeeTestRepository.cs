using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Data.Repositories
{
    public class EmployeeTestRepository : IEmployeeTestRepository
    {
        #region " Variable "
        List<EmployeeDetails> _employeeDetails;
        #endregion
        #region " Constructor "
        public EmployeeTestRepository()
        {
            _employeeDetails = new List<EmployeeDetails>()
            {
                   new EmployeeDetails() {First_Name="Doe1",Last_Name="John1",Email_Id="Doe1John1@vertexcs.com" },
                   new EmployeeDetails() {First_Name="Doe2",Last_Name="John2",Email_Id="Doe2John2@vertexcs.com" },
                   new EmployeeDetails() {First_Name="Doe3",Last_Name="John3",Email_Id="Doe3John3@vertexcs.com" },
            };
        }
        #endregion

        #region " Implementing IEmployeeTestRepository Interface Methods "
        /// <summary>
        /// // Adding Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeDetails AddEmployee(EmployeeDetails employeeDetails)
        {
            _employeeDetails.Add(employeeDetails);
            return employeeDetails;
        }

        /// <summary>
        /// Deleting Employee Data
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public EmployeeDetails DeleteEmployee(int employeeId)
        {
            EmployeeDetails employee = _employeeDetails.FirstOrDefault(e => e.Employee_Id == employeeId);
            if(employee!=null)
            {
                _employeeDetails.Remove(employee);
            }
            return employee;
        }

        /// <summary>
        /// // Retrieve Employee Details by employeeId
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public EmployeeDetails GetEmployeeById(int employeeId)
        {
            EmployeeDetails employee = _employeeDetails.Where(e => e.Employee_Id == employeeId).FirstOrDefault();
            return employee;
        }

        /// <summary>
        /// // Retrieve Employee Details
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDetails> GetEmployees()
        {
            var empList = _employeeDetails.ToList();
            return empList;
        }

        /// <summary>
        /// // Updating Employee Details by employeeId and Employee Object
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeDetails UpdateEmployee(int employeeId, EmployeeDetails employeeDetails)
        {
            EmployeeDetails employee = _employeeDetails.Where(e => e.Employee_Id == employeeId).FirstOrDefault();
            if(employee!=null)
            {
                employee.First_Name = employeeDetails.First_Name;
                employee.Last_Name = employeeDetails.Last_Name;
                employee.Email_Id = employeeDetails.Email_Id;
            }
            return employee;
        }
        #endregion
    }
}
