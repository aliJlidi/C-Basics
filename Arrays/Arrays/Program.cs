using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] grades = new int[5];
            //grades[0] = 20;
            //grades[1] = 13;
            //grades[2] = 15;
            //grades[3] = 20;
            //grades[4] = 16;
            //Console.WriteLine("index one is {0}", grades[0]);
            //grades[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("index one is {0}",grades[0]);
            //int[] gradesOfStudentA = { 20, 15, 14, 15, 14 };
            //int[] gradesOfStudentB = new int[] { 14, 10, 17, 20, 14, 12 };
            //Console.WriteLine("The length of the last table is {0}", gradesOfStudentB.Length);


            int[,] array2D = new int[,] { {1,2,3},{3,1,4},{8,4,7}};
            Console.WriteLine("The second line first column {0}", array2D[1,0]);
                Console.ReadKey();
        }
    }
}
