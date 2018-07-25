using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {

            Console.WriteLine("What is your age: ");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Your are of legal age." : "You are a child.";
            Console.WriteLine(test);

            //Console.WriteLine("What is your name?");
            //name = Console.ReadLine();


            //if (age <= 10)
            //{
            //    if (name == "Mateusz") 
            //    {     
            //        Method1();
            //    }

            //}
            //else if (age < 20)
            //{
            //    Method2();
            //}
            //else if (age <30)
            //{
            //    Method3();
            //}
            //else
            //{
            //    Method4();
            //}

            Console.ReadKey();
        }

        private static void Method4()
        {
            Console.WriteLine("Your age is higher than 30");
        }

        private static void Method3()
        {
            Console.WriteLine("You age is between 20 and 30.");
        }

        private static void Method2()
        {
            Console.WriteLine("Your age is between 10 and 20.");
        }


        private static void Method1()
        {
            Console.WriteLine("Your age is 10 or lower.");
        }
    }
}
