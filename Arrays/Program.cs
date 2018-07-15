using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            Arrays();

        }

        private static void Arrays()
        {
            float[] ratings;
            ratings = new float[5];

            AddRatings(ratings);



            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }

        }

        private static void AddRatings(float[] ratings)
        {
            ratings[0] = 5f;
            ratings[1] = 3.5f;
            ratings[2] = 9f;
            ratings[3] = 7f;
        }
    }
}
