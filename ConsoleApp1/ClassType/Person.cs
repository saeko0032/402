using System;
using System.Collections.Generic;
using System.Text;

namespace ClassType
{
    class Person
    {
        private int age;
        private string name;

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // Method
        public void Print()
        {
            Console.WriteLine("{0}{1} years old", name, age);
        }

    }
}
