using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreAPIClass9.Models
{
    [Table("TBL_NETCORE_EMPLOYEE_LEAVES")]
    public class EmployeeLeave
    {
        [Key]
        public int Leave_Id { get; set; }
        public int Employee_Id { get; set; }
        public int? Total_Leaves { get; set; }
    }
}
