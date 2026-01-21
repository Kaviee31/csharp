using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Employee list
            Employee emp1 = new Employee() { EmpId = 101, EmpName = "Kavitha Shanmugam", Address = "Pune", Salary = 60000, DeptId = 10 };
            Employee emp2 = new Employee() { EmpId = 102, EmpName = "Priya", Address = "Mumbai ", Salary = 10000, DeptId = 10 };
            Employee emp3 = new Employee() { EmpId = 103, EmpName = "Saira", Address = "Hyderabad ", Salary = 20000, DeptId = 20 };

            Employee emp4 = new Employee() { EmpId = 105, EmpName = "Mithra", Address = "Banglore ", Salary = 30000, DeptId = 20 };
            Employee emp5 = new Employee() { EmpId = 104, EmpName = "Pavi", Address = "Chennai ", Salary = 40000, DeptId = 40 };

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 };
            #endregion



            #region LINQ Query

            IEnumerable<Employee> query1 = from e in employees select e;

            IEnumerable<Employee> query2 = from e in employees where e.Address == "Banglore "
                                           select e;

            foreach (Employee item in query2)
            { Console.WriteLine(item.ToString());
            }

            //List all emps who are staying in pune and working in dept 10 and earning more than 25000

            IEnumerable<Employee> query3 = from e in employees
                                           where e.Address == "Pune" && e.DeptId == 10 && e.Salary > 25000
                                           select e;
            foreach (Employee e in query3)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("--------------------------------------------------");

            //List all emps  whose name begin with  p

            IEnumerable<Employee> query4 = from e in employees
                                           where e.EmpName.StartsWith("P")
                                           select e;
            Console.WriteLine("Employees whose name begin with P:");
            foreach (Employee e in query4)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------------------------------");

            //list all emps whose name have i
            IEnumerable<Employee> query5 = from e in employees
                                           where e.EmpName.Contains("i")
                                           select e;
            Console.WriteLine("Employees whose name have i:");
            foreach (Employee e in query5)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------------------------------");

            //list all emps whose name is  6 characters long
            IEnumerable<Employee> query6 = from e in employees
                                           where e.EmpName.Length == 6
                                           select e;
            Console.WriteLine("Employees whose name is 6 characters long:");
            foreach (Employee e in query6)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("--------------------------------------------------");

            //Sorting - order by
            // list all emps order by name ascending
            IEnumerable<Employee> query7 = from e in employees
                                           orderby e.EmpName ascending
                                           select e;
            Console.WriteLine("Employees order by name ascending:");
            foreach (Employee e in query7)
            {
                Console.WriteLine(e.ToString());
            }


            //List all emps as per salary h to l
            IEnumerable<Employee> query8 = from e in employees
                                           orderby e.Salary descending
                                           select e;
            Console.WriteLine("Employees order by salary descending:");
            foreach (Employee e in query8)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------------------------------");
            //List all emp as per department no.

            IEnumerable<Employee> query9 = from e in employees
                                           orderby e.DeptId ascending
                                           select e;

            Console.WriteLine("Employees order by DeptId ascending:");
            foreach (Employee e in query9)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------------------------------");

            // Multi column sorting
            //List all emps as per dept within dept h to l salary 
            IEnumerable<Employee> query10 = from e in employees
                                            orderby e.DeptId ascending, e.Salary descending
                                            select e;
            Console.WriteLine("Employees order by DeptId ascending and Salary descending:");
            foreach (Employee e in query10)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------------------------------");


            #endregion

            #region LINQ Method Syntax
            string msg = " Learning Language Integrated Query ";
            // Print numbers of words in string msg 
            var words = msg.Trim().Split(' ').Length;
            Console.WriteLine($"No of words in the given string {words}");

            Console.WriteLine(msg.WordCount());

            // List all emps name, address, and dept
            IEnumerable<Employee> query11 = from e in employees select e;
            IEnumerable<string> query11a = from e in employees select e.EmpName;
            IEnumerable<double> query11b = from e in employees select e.Salary;
            var query12 = from e in employees
                          select new
                          {
                              e.EmpName,
                              e.DeptId,
                              e.Salary
                          };
            foreach(var item in query12)
            {
                Console.WriteLine(item);
            }
            query12 = employees.Select(e => new { e.EmpName, e.DeptId, e.Salary });
            // List all emps name, address, and dept who all are earning salary >25000
            var query13 = employees.Where(e => e.Salary > 25000).Select(e => new { e.EmpName, e.DeptId, e.Salary });


            #endregion

            #region AnonymousType
            Employee employee = new Employee() { EmpId = 1, EmpName = "kavi", Address= "Chennai", DeptId = 10, Salary = 1000};
            //new {} - anonymous type & read-  only properties
            // new { Employee.Empname, employee.Address, employee.DeptId};
            //var - implicitly typed local variable

            var p = new { employee.EmpName, employee.Address, employee.DeptId, employee.Salary };

            #endregion

            #region Aggregate Function
            //sum, avg, min, max, count
            //Find total salary for all emps

            double totalSal = (from e in employees select e).Sum
                (e => e.Salary);

            //1. Find avg Salary of Organization
            // list all emps who are earning more than average salary 
            var query18 = (from e in employees select e).Average(e => e.Salary);
            Console.WriteLine(query18);

            var query19 = employees.Average(e => e.Salary);
            var query20 = employees.Where(e => e.Salary > query19);
            List<Department> departments = new List<Department>()
            {
                new Department() { DeptId = 1, DeptName = "HR" },
                new Department() { DeptId = 2, DeptName = "IT" },
                new Department() { DeptId = 3, DeptName = "Finance" }
            };

            
            var query21 = from e in employees
                          join d in departments
                          on e.DeptId equals d.DeptId
                          select new { e.EmpName, e.Address, d.DeptName, e.Salary };

            foreach(var item in query21)
            {
                Console.WriteLine(item);
            }

            // deferred and immediate execution
            //deferred execution
            Console.WriteLine("-------------" + employees.Count);

            //immediate execution
            var query31 = (from e in employees select e).ToList();

            // employees.Add(new Employee() { EmpId = 201, });
            Employee employee1 = employees.SingleOrDefault(e => e.EmpId == 101);
            employee = employees.Where(e => e.EmpId == 101).SingleOrDefault();
            if (employee1 != null)
            {
                Console.WriteLine(employee1);
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

            #endregion
        }
    }
}
