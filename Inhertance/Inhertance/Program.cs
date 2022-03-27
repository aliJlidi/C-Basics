using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee micheal = new Employee("Micheal", "Miller", "3000");
            micheal.Work();
            micheal.Pause();
            Boss jack = new Boss("Honda", "Jack", "Norris", "9999");
            jack.Lead();
            Trainee Denis = new Trainee(32, 74, "Denis", "Linda", "300");
            Denis.Work();
            Denis.Learn();
            Console.ReadKey();
        }
    }
}
