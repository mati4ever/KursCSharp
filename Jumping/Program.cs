using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumping
{
    class Program

    {
        

        static void Main(string[] args)
        {

            int[] ages = { 1, 2, 3, 4, 5, 6, 7 };

            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine($"Wiek wynosi: {age} ");
            //        continue;
            //        Console.WriteLine("Hello");
            //    }

            //    if (age ==4 )
            //    {
            //        Console.WriteLine($"Wiek wynosi: {age} ");
            //        break;
            //        Console.WriteLine("Hello");
            //    }
            //}


            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine($"Wiek wynosi: {age} ");
            //        goto skip;
            //    }

            //    if (age == 4)
            //    {
            //        Console.WriteLine($"Wiek wynosi: {age} ");
            //        break;
            //        Console.WriteLine("Hello");
            //    }
            //}

            //skip:
            //Console.WriteLine("Hello.");

            CheckAges(ages);



            Console.ReadKey();
        }

        private static void CheckAges(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age ==3)
                {
                    Console.WriteLine($"Wiek wynosi: {age}");
                    return;
                }
            }
        }
    }
}
