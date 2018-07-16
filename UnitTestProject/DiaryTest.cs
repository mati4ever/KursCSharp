using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDiary;

namespace UnitTestProject
{
    [TestClass]
    public class DiaryTest
    {

        [TestMethod]
        public void CalculateMaxGrade()
        {

            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(7);
            diary.AddRating(14);
            diary.AddRating(9);
            diary.AddRating(3.5f);

            DiaryStatistics stats = diary.ComputeStatistics();


            Assert.AreEqual(9f, stats.maxGrade);

        }

        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Matthew";

            SetName(diary);

            Assert.AreEqual("Michal", diary.Name);

        }

        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;
            IcrementNumber(x1);

            Assert.AreEqual(5, x1);

        }

        [TestMethod]
        public void PassByRefInt()
        {
            int x1 = 5;
            IcrementNumber(ref x1);

            Assert.AreEqual(6, x1);

        }

        private void IcrementNumber(ref int number)
        {
            number++;
        }

        private void IcrementNumber(int number)
        {
            number++;
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Michal";
        }
    }
}
