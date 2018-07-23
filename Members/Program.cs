using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {

            Diary diary = new Diary();
            diary.AddRating(8.5f);
            diary.AddRating(5f);
            diary.AddRating(3.5f);

            DiaryStatistics stats = diary.ComputeStatistics();

            WriteResult("Average", stats.averageGrade, 5,7,8);
            WriteResult("Highest rating", (int)stats.maxGrade);
            WriteResult("Lowest rating" , (long)stats.minGrade);
            WriteResult("TEST", stats.minGrade, 1);

            Console.ReadKey();

        }

        private static void WriteResult(string description, params float[] result)
        { 
            Console.WriteLine(description + ": " + result[0] + result[1] + result[2]);
        }

        private static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        private static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        private static void WriteResult(string description, float result, long test)
        {
            // Dwa równoważne zapisy - znak $ pozwala na bezpośrednie zapisanie w place holderze parametru.
            Console.WriteLine("{0} {1:F2} {2:C} {3:C1} {4} {5}", description, result , 2,3,4,5);
            Console.WriteLine($"{description} {result:F2} {2:C} {3:C1} {4} {5}"); 
         
        }

    }
}
