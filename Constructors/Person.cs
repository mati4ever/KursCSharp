using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string addres;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Matthew";
            lastName = "Zaho";
            addres = "Zamość";
            age = 25;   
        }

        public Person(int id, string firstName, string lastName, string addres, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.addres = addres;
            this.age = age;
            this.gender = gender;
            
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            addres = "Warszawa";
            age = 18;
        }


    }

}
