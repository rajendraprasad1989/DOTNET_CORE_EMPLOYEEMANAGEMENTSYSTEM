using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreAPIClass9.Models
{
        [Table("TBL_NETCORE_EMPLOYEE")]
        public class Employee
        {
        [Key]
            public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First Name is Requires")]
            public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Requires")]
            public string LastName { get; set; }
        [Required(ErrorMessage = "EmailId is Requires")]
            public string EmailId { get; set; }
        [Required(ErrorMessage = "PhoneNo is Requires")]
            public string PhoneNo { get; set; }
        }
}
