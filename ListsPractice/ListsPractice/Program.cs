using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine("current value {0}", i);
            }
            Console.ReadKey();
        }
    }
}
