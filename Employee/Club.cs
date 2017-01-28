using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Club
    {
        List<Employee> members;
        public void AddEmployee(Employee NewEmployee)
        {
            NewEmployee.fire += RemoveEmployee;
            NewEmployee.retire += RemoveEmployee;
            members.Add(NewEmployee);
        }

        public void RemoveEmployee(Employee RemovedEmployee)
        {
            Console.WriteLine(RemovedEmployee.Name);
            members.Remove(RemovedEmployee);
        }
        public Club()
        {
            members = new List<Employee>();
        }
    }
}
