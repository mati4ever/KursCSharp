using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {

            diary.Name = "Matthew diary.";

        }

        static void IncrementNumber(out int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            // PassByValueAndRef();








            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            //for (; ; )
            //{
            //    Console.WriteLine("Write your rating from 1 to 10 : ");
            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(),out rating );

            //    if (rating == 11)
            //    {
            //        break;
            //    }

            //    if (result == true)
            //    {
            //        if (rating >0 && rating <= 10)
            //        {
            //            diary.AddRating(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong rating!");
            //        }

            //    }


            //}

            //Console.WriteLine("Your average is: " + stats.averageGrade);
            //Console.WriteLine("Your highest rating is: " + stats.maxGrade);
            //Console.WriteLine("Your lowewst rating is: " + stats.minGrade);

            Console.ReadKey();



        }

        private static void PassByValueAndRef()
        {
            Diary diary = new Diary();

            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            //Console.WriteLine(Diary.maxGrade);

            Diary diary2 = new Diary();
            Diary diary3 = diary2;
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();

            GiveName(ref diary2);

            Console.WriteLine(diary3.Name);

            Console.WriteLine(Diary.count);

           
        }
    }
}
 