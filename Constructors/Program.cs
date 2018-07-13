using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Person person2 = new Person( 5, "Mateusz", "Kimak");
            Person person3 = new Person(10, "Józed", "Kowal", "Katowice", 30, "male");
             


        }
    }
}
