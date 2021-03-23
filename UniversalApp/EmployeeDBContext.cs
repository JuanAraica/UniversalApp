using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalApp
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
        : base(options)
        { 
        }
public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
    }
}
