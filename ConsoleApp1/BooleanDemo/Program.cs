using System;

namespace BooleanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1;
            b1 = false; // withoud initialize, it will show error
            Console.WriteLine(b1);
            b1 = true;
            Console.WriteLine(b1);
            int a = 1;
            bool b2 = (a == 1); // if a == 1, true
            Console.WriteLine(b2);
            Console.Read();
        }
    }
}
