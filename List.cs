using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQJoin
{
    class List
    {
        List<Department> departments = Department.getDepartments();
        List<Employee> employees = Employee.getEmployees();
        public List() { }
        public void GetMaxSalary()
        {
            var maxSalary = employees.Max(employee => employee.Salary);
            Console.WriteLine("Luong cao nhat: " + maxSalary);
        }
        public void GetMinSalary()
        {
            var minSalary = employees.Min(employee => employee.Salary);
            Console.WriteLine("Luong thap nhat: " + minSalary);
        }
        public void GetAverageSalary()
        {
            var averageSalary = employees.Average(employee => employee.Salary);
            Console.WriteLine("Luong trung binh: " + averageSalary);
        }
        public void GetGroupJoin()
        {
            var employeesByDepartment = from d in departments
                                        join e in employees
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employee = eGroup
                                        };
            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine("Ten department: " + department.Department.Name);
                foreach (var employee in department.Employee)
                {
                    Console.WriteLine("Ten nhan vien: " + employee.Name);
                }
                Console.WriteLine();
            }
        }
        public void GetLeftJoin()
        {
            var listLeftJoin = from e in employees
                               join d in departments
                               on e.DepartmentID equals d.ID into eGroup
                               from d in eGroup.DefaultIfEmpty()                             
                               select new
                               {
                                   EmployeeName = e.Name,
                                   DepartmentName = d == null ? "No Department" :d.Name
                               };
            foreach (var employee in listLeftJoin)
            {
                Console.WriteLine("{0} - {1}", employee.EmployeeName, employee.DepartmentName);
            }
        }
        public void GetMaxAge()
        {
            var maxAge = employees.Min(employee => employee.Birthday.Year);
            int difference = DateTime.Now.Year - maxAge;
            Console.WriteLine("Tuoi cao nhat: " + difference);
        }
        public void GetMinAge()
        {
            var minAge = employees.Max(employee => employee.Birthday.Year);
            int difference = DateTime.Now.Year - minAge;
            Console.WriteLine("Tuoi thap nhat: " + difference);
        }
    }
}
