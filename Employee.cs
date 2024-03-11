using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQJoin
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }
        public int DepartmentID { get; set; }
        public static List<Employee> getEmployees()
        {
            return new List<Employee>()
            {
                new Employee{ID = 1, Name = "A", Age = 20, Salary = 1000, Birthday = new DateTime(2004, 01, 10), DepartmentID = 1},
                new Employee{ID = 2, Name = "B", Age = 21, Salary = 1500, Birthday = new DateTime(2003, 01, 10), DepartmentID = 2},
                new Employee{ID = 3, Name = "C", Age = 22, Salary = 3000, Birthday = new DateTime(2002, 01, 10), DepartmentID = 3},
                new Employee{ID = 4, Name = "D", Age = 23, Salary = 2500, Birthday = new DateTime(2001, 01, 10), DepartmentID = 1},
                new Employee{ID = 5, Name = "E", Age = 24, Salary = 2000, Birthday = new DateTime(2000, 01, 10), DepartmentID = 2}
            };
        }
    }
}
