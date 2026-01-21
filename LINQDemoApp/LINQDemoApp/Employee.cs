using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
      public string Address { get; set; }
        public double Salary { get; set; }
        public int DeptId { get; set; }

        public override string ToString()
        {
            return $"EmpId: {EmpId},\t EmpName: {EmpName.PadRight(15)},\t Address: {Address.PadRight(15)},\t Salary: {Salary},\t DeptId: {DeptId}";
        }   

    }
}
