using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    class Department
    {
        public string Name;
        public double EmployeLimit;
        public double SallaryLimit;

        public Employee[] Employees = new Employee[0];
        
        public void AddEmployee(Employee employee1)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee1;
        }
       
    }
}
