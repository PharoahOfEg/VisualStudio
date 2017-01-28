using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Department
    {
        public string Name { get; set; }
        List<Employee> employees;
        public void AddEmployee(Employee NewEmployee)
        {

            NewEmployee.fire += RemoveEmployee;
            NewEmployee.retire += RemoveEmployee;
            employees.Add(NewEmployee);
        }

        public void RemoveEmployee(Employee RemovedEmployee)
        {
            Console.WriteLine(RemovedEmployee.Name);
            employees.Remove(RemovedEmployee);

        }
        public Department(string name)
        {
            employees = new List<Employee>();
            Name = name;
        }
    }
}
