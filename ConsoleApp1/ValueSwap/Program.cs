using System;

namespace ValueSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("x={0} y={1}", x, y);
            Program.Swap(x, y); // 5,10,
            Program.Swap2(ref x,ref y); // ref = reference
            Console.WriteLine("x={0} y={1}", x, y); // 1) 5,10 2) 10,5

            Program p = new Program();
            p.PrintNum(); // start = 0, end = 20
            p.PrintNum(5, 10); // start = 5, end = 10
            p.PrintNum(15); // start = 15, end = 20(default)
            p.PrintNum(end:40, start: 35); // start = 35, end = 40


            Console.Read();
        }
        static void Swap(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a={0} b={1}", a, b); // 10.5
        }

        static void Swap2(ref int a,ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a={0} b={1}", a, b); // 10.5
        }

        public void PrintNum(int start = 0, int end = 20)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        // when i want to use multiple value to assing i can use out keyword
        static void Method(out int i, out string s1, out string s2)
        {
            i = 44;
            s1 = "teta";
            s2 = null;
        }

    }
}
