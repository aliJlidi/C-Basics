using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Employee
    {
        public string name { get; set; }
        public string firstName { get; set; }
        public string salary { get; set; }

        public Employee()
        {
            name = "Jack";
            firstName = "Loris";
            salary = "3000";
        }
        public Employee(string name, string firstName, string salary)
        {
            this.name = name;
            this.firstName = firstName;
            this.salary = salary; 
        }
        public void Work()
        {
            Console.WriteLine("I'm in work");
        }
        public void Pause()
        {
            Console.WriteLine("I'm taking a rest");
        }
    }
}
