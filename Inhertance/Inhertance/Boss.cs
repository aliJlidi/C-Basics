using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Boss : Employee
    {
        public string companyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, string salary):base(name,firstName,salary)
        {
            this.companyCar = companyCar; 
        }
        public void Lead()
        {
            Console.WriteLine("I Lead My name is {0} {1}",firstName,name);
        }
    }
}
