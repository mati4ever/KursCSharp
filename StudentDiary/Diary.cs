using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        List<float> ratings;


        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.averageGrade = sum / ratings.Count();
            stats.maxGrade = ratings.Max();
            stats.minGrade = ratings.Min();


            return stats;
        }


        /// <summary>
        ///     Adding rating to diary.
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        ///// <summary>
        /////  Calculating the average of our rating.
        ///// </summary>
        ///// <returns></returns>
        //public float CalculateAverage()
        //{
        //    float sum = 0, avg = 0;

        //    foreach (var rating in ratings)
        //    {

        //        sum += rating;
        //    }

        //    avg = sum / ratings.Count();
        //    return avg;

        //}

        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return ratings.Min();

        //}


    }
}
