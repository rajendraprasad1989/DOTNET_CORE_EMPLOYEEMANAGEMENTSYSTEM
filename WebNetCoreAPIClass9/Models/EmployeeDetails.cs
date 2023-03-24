using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreAPIClass9.Models
{
    public class EmployeeDetails
    {
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Id { get; set; }
        public string PhoneNo { get; set; }
        public int? Total_Leaves { get; set; }
    }
}
