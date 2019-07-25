using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Class_Dec_Float_Double
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter your name:  ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your current address:  ");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your email address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter a 4 digit number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0}, you live at {1}, you are {2} years old, your email address is {3},",name,address,age,email);
            Console.WriteLine("and this is your four digit number {0}",num);
            Console.ReadLine();


        }
    }
}
