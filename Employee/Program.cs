using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ahmed");
            Department dep = new Department("Gaming");
            Club club = new Club();
            dep.AddEmployee(emp);
            club.AddEmployee(emp);
            emp.Age = 80;
            Console.WriteLine(emp.Age );
        }
    }
}
