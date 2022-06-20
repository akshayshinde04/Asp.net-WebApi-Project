using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptMVC.Models
{
    public class Dept
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }
        public string Branches { get; set; }
    }
}
