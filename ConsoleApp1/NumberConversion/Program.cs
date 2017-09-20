using System;

namespace NumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numValue = -1;
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine(); // read line is always string
            try
            {
                numValue = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("input string is not a sequence of digits" + e.Message);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("the number cannot fit in int32");
            }
            finally
            {
                if (numValue < Int32.MaxValue)
                {
                    Console.WriteLine("myValue = {0}", numValue);
                }
            }
            int a = int.Parse(Console.ReadLine());
            float f = float.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}",a,f,d);

            string str = Console.ReadLine();
            int number;
            if(int.TryParse(str, out number)) // try to parse from str, if its true assign it to number
            {

            }



            Console.Read();
        }
    }
}
