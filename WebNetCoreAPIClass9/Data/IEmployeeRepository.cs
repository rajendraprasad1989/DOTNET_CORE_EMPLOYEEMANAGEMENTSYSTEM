using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Data
{
    #region " Interface Declaration "
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int employeeId);
    }
    #endregion
}
