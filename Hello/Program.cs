using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (int i = 0; i < 5; i++)
            {
                Greeting();
                Age();
                Settings();

            }

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Hello " + item);
            //}

        }

        /// <summary>
        ///  This method check maximum and minimum value of specific types.
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        ///   Default settings.
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        ///   Checking user age.
        /// </summary>
        private static void Age()
        {
            Console.Write("What is your age: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Great you can drink beer.");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, wrong age!");
            }
            else
            {
                Console.WriteLine("Sorry you can drink milk.");
            }
        }
        
        /// <summary>
        ///  Print user greeting.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Write your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
