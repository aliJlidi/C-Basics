using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Trainee : Employee
    {
        public int workingHour { get; set; }
        public int schoolHour { get; set; }

        public Trainee(int workingHour, int schoolHour, string name, string firstName, string salary)
        {
            this.workingHour = workingHour;
            this.schoolHour = schoolHour; 
        }
        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours", schoolHour);
        }
        public void Work()
        {
            Console.WriteLine("I'm wroking for {0} hours", workingHour);
        }

    }
}
