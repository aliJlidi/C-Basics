using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thank you for the gift", true, "Ali");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Ali Jlidi", "https://images.com", true);
            Console.WriteLine(imagePost1.ToString()); 
            Console.ReadKey();
        }
    }
}
