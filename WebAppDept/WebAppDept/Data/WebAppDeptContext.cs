using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDept.Models;

namespace WebAppDept.Data
{
    public class WebAppDeptContext : DbContext
    {
        public WebAppDeptContext (DbContextOptions<WebAppDeptContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppDept.Models.Department>? Department { get; set; }
    }
}
