using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,4);
            box.DisplayInfo();
            Console.WriteLine(box.FrontSurface);
            box.Width = 10;
            box.DisplayInfo();

            Console.ReadKey();
        }
    }
}
