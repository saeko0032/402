using System;
using System.Collections.Generic;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 51;
            Console.WriteLine("series from 1 to 50");
            while (i <= 50)
            {
                Console.Write("\t{0}",i);
                i++;
            }

            int j = 51; // do loop -> can execute 1 time
            Console.WriteLine("\nseries from 1 to 50");
            do
            {
                Console.Write("\t{0}", j); // 51
                j ++;
            } while (j <= 50);

            int n = 5;
            int factorial = 1;
            for(int k = n; k >= 1; k--)
            {
                factorial = factorial * k;
            }
            Console.WriteLine("factorial = {0}", factorial);

            string[] days = new string[]
                {
                    "Mon","Tue","Wed","Thu","Fri","Sat","Sun"
                };
            foreach (string day in days)
            {
                Console.WriteLine(day);
            }

            // jagged array
            int[] numbers = { 0, 1, 4, 114, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] rows = new int[3];
            // row[0] = columns?
            // row[1] = columns?
            // row[2] = columns?
            foreach (var no in numbers) // var = varidabke & takes any data type
            {
                int reminder = no % 3;
                rows[reminder]++;
            }
            int[][] numbersByReminder = new int[3][]
            {
                new int[rows[0]],
                new int[rows[1]],
                new int[rows[2]]
            };
            // 1. find th reminder = no % 3

            Console.WriteLine(numbersByReminder[0][0]);
            int[] lamNumbers = { 1, 2, 5, 10, 11, 12 };
            Array.Sort(lamNumbers, (x,y) => (y%6).CompareTo(x%6));
            foreach (int no in numbers)
            {
                Console.Write("{0}\t",no);
            }

        string[] students = { };


            Console.Read();
        }
        private class StudentComparator : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                // use var forreferene datatype
                // if value type then use int...
                var lastName1 = x.Substring(x.IndexOf(' ') + 1);
                var lastName2 = y.Substring(x.IndexOf(' ') + 1);
                return lastName1.CompareTo(lastName2);

            }
        }
    }
}
