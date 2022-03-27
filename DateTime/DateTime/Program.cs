using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("My birthday is {0}", dateTime);
            Console.WriteLine(DateTime.Now);
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomrrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            DateTime now = DateTime.Now;
            Console.WriteLine("Now it's : {0} o'clock , {1} minutes and {2} seconds", now.Hour , now.Minute , now.Second);
            Console.WriteLine("write a date in this format : yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Years passed since: {0}", daysPassed.Days/365);
            }
            else
            {
                Console.WriteLine("Enter right date format");
            }
            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
