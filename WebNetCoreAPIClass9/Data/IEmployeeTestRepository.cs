using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9.Data
{
    public interface IEmployeeTestRepository
    {
        List<EmployeeDetails> GetEmployees();
        EmployeeDetails GetEmployeeById(int employeeId);
        EmployeeDetails UpdateEmployee(int employeeId, EmployeeDetails employeeDetails);
        EmployeeDetails DeleteEmployee(int employeeId);
        EmployeeDetails AddEmployee(EmployeeDetails employeeDetails);
    }
}
