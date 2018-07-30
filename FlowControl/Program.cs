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
            //instructioIf();
            //InstructionSwitch();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int a = 0; a < 3; a++)
            //    {
            //        Console.WriteLine($"Wartość i = : {i}, wartość a = : {a} ");
            //    }

            //}

            //int i = 0;

            //while (i < 3)
            //{
            //    Console.WriteLine("Hello.");
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("Hello.");
            //    i++;
            //} while (i > 3);

            //int[] tab = {1,2,3,5,8,12,21};

            //foreach (var item in tab)
            //{

            //    Console.WriteLine(item);

            //}

            for (; ; )
            {
                Console.WriteLine("Hello.");
            }

            Console.ReadKey();
        }
        #region Private methods

        private static void InstructionSwitch()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();


            switch (name)
            {
                case "Mateusz":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    break;
                case "Jacek":
                    Method3();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void instructioIf()
        {
            Console.WriteLine("What is your age: ");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Your are of legal age." : "You are a child.";
            Console.WriteLine(test);

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();


            if (age <= 10)
            {
                if (name == "Mateusz")
                {
                    Method1();
                }

            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
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

        #endregion
    }
}
