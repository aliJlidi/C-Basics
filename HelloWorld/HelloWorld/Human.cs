using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // this class is a blueprint
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        // Default constructor
        public Human()
        {
            Console.WriteLine("constructed called , Object created");

        }
        // paramzterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;

        }
        public void introduceMySelf()
        {
            if (age != 0) { 
            Console.WriteLine("My name is {0} {1} and I like {2} I'm aged {3}",firstName,lastName,eyeColor,age);
            }
            else
            {
                Console.WriteLine("My name is {0} {1} and I like {2} ", firstName, lastName, eyeColor);
            }
        }

    }

}
