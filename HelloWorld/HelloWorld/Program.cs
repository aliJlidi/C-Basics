using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a object 
          Human denis = new Human("Kanow","Ringo","Black",23);
          denis.introduceMySelf();
          Human alia = new Human("Losa", "Minga", "Blue");
          alia.introduceMySelf();
          Human basicHuman = new Human();
          basicHuman.introduceMySelf();
          Console.ReadKey();        
        }
    }
}
