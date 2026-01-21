using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    internal class Department
    {
        public int? DeptId { get; set; }
        public string DeptName { get; set; } 
        
        public override string ToString()
        {
            return $"DeptId: {DeptId}, DeptName: {DeptName}";
        }
    }
}
