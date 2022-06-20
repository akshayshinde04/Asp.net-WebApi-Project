using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeptMVC.Models;

namespace DeptMVC.Data
{
    public class DeptMVCContext : DbContext
    {
        public DeptMVCContext (DbContextOptions<DeptMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DeptMVC.Models.Dept> Dept { get; set; }
    }
}
