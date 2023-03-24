using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreAPIClass9.Models
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
    }
}
