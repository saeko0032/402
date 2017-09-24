using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Program.Task1();
            // Program.Task2();
            Program.Task3();
        }

        static void Task1()
        {
            for (int j = 0; j <= 5; j++)
            {
				for (int i = 1; i < j; i++)
				{
					Console.Write("*");
				}
                Console.WriteLine("");

			}
			for (int j = 0; j <= 5; j++)
			{
				for (int i = 1; i < j; i++)
				{
                    Console.Write("{0}",i);
				}
				Console.WriteLine("");

			}
        }
        static void Task2()
        {
            Console.WriteLine("Input the size of the square matrix (less than 5):");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            Console.WriteLine("Input elements in the first matrix:");
			int[,] firstMatrix = new int[rows, cols];
			int[,] secondMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("element - [{0}],[{1}]", i, j);
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
			}
            Console.WriteLine("Input elements in the second matrix:");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.WriteLine("element - [{0}],[{1}]", i, j);
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("The first Matrix is");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
                    Console.Write(" {0}", firstMatrix[i, j]);
				}
                Console.WriteLine("");
			}
			Console.WriteLine("The second Matrix is");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(" {0}", secondMatrix[i, j]);
				}
				Console.WriteLine("");
			}
			Console.WriteLine("The Addition of two Matrix is");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(" {0}", firstMatrix[i,j] + secondMatrix[i, j]);
				}
				Console.WriteLine("");
			}
        }
        static void Task3()
        {
            Console.WriteLine("Enter a number:");
			int number = int.Parse(Console.ReadLine());
            int fib = Program.Fibonacchi(number);
            Console.WriteLine("The Fibonacci of {0} th term is {1}", number, fib);


		}
        public static int Fibonacchi(int n)
        {
            if (n <= 2)
            {
                return 1;

            } else
            {
                return Fibonacchi(n - 1) + Fibonacchi(n - 2);
            }
        }
    }
}
