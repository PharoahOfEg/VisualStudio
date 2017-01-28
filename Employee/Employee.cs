using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    delegate void AddRemoveEmloyee(Employee emp);
    class Employee
    {
        /*
         * employee
         *      name,id,days(el ayam l 8abha),age
         * events: fire, retire
         * types:
         *      sales y8eeb bra7to
         *      CEO akeed msh hytrefed
         *      el 3ady byetnefe5
         * department
         *      name,employee[]
         *      subscribe fire, retire
         * club 
         *      employee[]
         *      subscribe fire
         * 3ada 20 youm 8yab rafd etrafad yetshal mn dept w club
         * lw 3ada 60 sana yetshal mn dept
         */
        int age;
        int days;
        public string Name { get; set; }
        public int ID { get; set; }
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                if (value > 0 && value < 20)
                    days = value;
                else
                {
                    fire(this);
                    days = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>0&&value<60)
                {
                    age = value;
                }
                else
                {
                    retire(this);
                    age = value;
                }
            }
        }
        public EmployeeType Type { get; set; }
        public event AddRemoveEmloyee fire;
        public event AddRemoveEmloyee retire;
        public Employee(string name)
        {
            Name = name;
        }
    }
}

enum EmployeeType
{
    Sales,
    CEO,
    Normal
}
