using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace EmployeeManagment.Data
{
    public class EmployeeManagmentContext : DbContext
    {
        public EmployeeManagmentContext (DbContextOptions<EmployeeManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<Employee.Models.MyEmployee> MyEmployee { get; set; }
    }
}
