using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            count ++;
        }

        List<float> ratings;

        public static float minGrade = 0;
        public static float maxGrade = 10;
        public static long count = 0;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!String.IsNullOrEmpty(value)) _name = value;
            }
        }

        public DiaryStatistics ComputeStatistics()
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
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
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
