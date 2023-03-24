using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Data.Repositories
{
        public class EmployeeRepository : IEmployeeRepository
        {
        #region " Variable "
        private readonly EMSContext _emsContext;
            #endregion
            #region " Constructor "
            public EmployeeRepository(EMSContext emsContext)
            {
                _emsContext= emsContext;
            }
            #endregion

            #region " Implementing IEmployeeRepository Interface Methods "
            /// <summary>
            /// // Adding Employee
            /// </summary>
            /// <param name="employee"></param>
            /// <returns></returns>
            public Employee AddEmployee(Employee employee)
            {
                _emsContext.Add(employee);
                _emsContext.SaveChanges();
                return employee;
            }

        /// <summary>
        /// Deleting Employee Data
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee DeleteEmployee(int employeeId)
            {
                Employee deleteEmployee = _emsContext.Employees.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
                if (deleteEmployee != null)
                {
                    _emsContext.Remove(deleteEmployee);
                    _emsContext.SaveChanges();
                }
            return deleteEmployee;
            }

            /// <summary>
            /// // Retrieve Employee Details by employeeId
            /// </summary>
            /// <param name="employeeId"></param>
            /// <returns></returns>
            public Employee GetEmployeeById(int employeeId)
            {
                Employee employee = _emsContext.Employees.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
                return employee;
            }

            /// <summary>
            /// // Retrieve Employee Details
            /// </summary>
            /// <returns></returns>
            public List<Employee> GetEmployees()
            {
                var empList = _emsContext.Employees.ToList();
                return empList;
            }

            /// <summary>
            /// // Updating Employee Details by employeeId and Employee Object
            /// </summary>
            /// <param name="employeeId"></param>
            /// <param name="employee"></param>
            /// <returns></returns>
            public Employee UpdateEmployee(Employee employee)
            {
                Employee updateEmployee = _emsContext.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
                //if (updateEmployee != null)
                //{
                updateEmployee.EmployeeId = employee.EmployeeId;
                    updateEmployee.FirstName = employee.FirstName;
                    updateEmployee.LastName = employee.LastName;
                    updateEmployee.EmailId = employee.EmailId;
                    updateEmployee.PhoneNo= employee.PhoneNo;
                    _emsContext.Employees.Update(updateEmployee);
                    _emsContext.SaveChanges();
                //}
                return updateEmployee;
            }
            #endregion
        }
    }
