using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("result={0}:",Program.Exercise2(5.3f, 6.01f));
            Console.WriteLine("result={0}:", Program.Exercise2(5.00000001f,5.00000003f));
            Program.Exercise3();
            Program.Exercise4();
            Program.Exercise5();
            Console.Read();

        }

        public void Exercise1()
        {
            // byte sbyte short ushort int uint long ulong
            //byte : 0 -255 sbyte : -128 to 127 ushort 0 to 65535 
            byte num1 = 97;
            sbyte num2 = -115;
            ushort num3 = 52130;
            uint num4 = 4825932;
            short num5 = -10000;
        }

        static bool Exercise2(float f1, float f2)
        {
            return f1 == f2;
        }

        static void Exercise3()
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj1 = str1 + " " + str2;
            string str3 = (string)obj1;
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(obj1);
            Console.WriteLine(str3);

        }

        static void Exercise4()
        {
            // about ascii
            // ASCII (American Standard Code for Information Interchange) is the most common format for text files in computers
            // and on the Internet. In an ASCII file, each alphabetic, numeric, or special character is represented 
            // with a 7-bit binary number (a string of seven 0s or 1s). 128 possible characters are defined.
            for(int i = 0; i<128; i++)
            {
                char temp = (char)i;
                Console.WriteLine("{0}", temp);
            }
        }

        static void Exercise5()
        {
            int? num1 = null;
            double? num2 = null;
            Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);
            num1 = 3; num2 = 4;
            Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);
            num1 = null; num2 = null;
            Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);

        }

    }
}
