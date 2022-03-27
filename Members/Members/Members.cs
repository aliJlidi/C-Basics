using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Members
    {
        // private fieled 
        private string memberName;
        private string jobTitle;
        private int salary;
        // public fieled 
        public int age;

        // propereties

        public string JobTitle
        {
            get 
        {
            return jobTitle;
        }
            set
            {
                jobTitle = value;
            }
        }
        // public member Method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("My name is {0} and my job is {1} and I am {2} years old",memberName , jobTitle , age);
            }
        }
        private void sharingPrivateInfo(){
            Console.WriteLine("My salary is {0}", salary);
        }
        // constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created ");
        }
        //finalizer -destructor 
        ~Members()
        {
            // clean up statement
            Console.WriteLine("destruction of the object");
        }
    }
}
