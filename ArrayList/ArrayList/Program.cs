using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList();


            myArrayList.Add(20);
            myArrayList.Add("Hello");
            myArrayList.Add(13.5);
            myArrayList.Add(0.5);
            myArrayList.Add(45);

            // remove by value 
            myArrayList.Remove(0.5);
            // remove by index 
            double sum = 0; 

            foreach(object obj in myArrayList){
                if(obj is int){
                    sum += Convert.ToDouble(obj);
                }else if(obj is double) {
                    sum +=(double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
