using System;

namespace ByteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myValue = 255;
            byte x = 10, y = 20;
            char char1 = 'X';
            char char2 = '\x0058'; // hx
            char char3 = (char)88; // cast from integer value
            char char4 = '\u0058';
            decimal myDecimalValue1 = 300.07m; // for decimal we need to add 
            decimal myDecimalValue2 = 9.1m;
            int z = 3;
            decimal decimalX = 0.999m;
            decimal decimalY = 99999m;
            Console.WriteLine("Byte values mybyte = {0}", myValue);
            Console.WriteLine("Byte values x = {0} y = {1} myValue = {2}", x, y, myValue);
            Console.WriteLine("Byte values char1 = {0} char2 = {1} char3 = {2} char4 = {3}", char1, char2, char3, char4);
            Console.WriteLine("myDecimal value = {0}", myDecimalValue1);
            Console.WriteLine(myDecimalValue2 + z); // decimal > int, so it will covert to decimal number -> 12.1
            Console.WriteLine("my x = {0:C}", decimalX); //$1.00
            Console.WriteLine("my x = {0:P}", decimalX); //99.90 %
            Console.WriteLine("my y = {0:C}", decimalY); // $99,999.00
            // Add D/d only if you want integer to be treated as double otherwise its ok
            double d1 = 2D;
            double d2 = 1.76E+10;
            Console.WriteLine("d1={0}", d1);
            Console.WriteLine("de={0}", d2);
            // float
            float pi = 3.1415926535897932f; // ->3.145
            Console.WriteLine("{0:F3}", pi); // Fixed upto 3 digi

            Console.WriteLine("pi={0}", pi);

            double someVal = 1.234;// ->01.234000
            Console.WriteLine("{0:00.000000}", someVal);

            Console.WriteLine("{0:X}", 250);
            // stromg formatting with left align or right align
            double colaPrice = 1.20;
            string cola = "Coca cola";
            double fantaPrice = 1.20;
            string fanta = "Fanta DIZZY";
            double pepsiPrice = 1.50;
            string pepsi = "pepsi";

            Console.WriteLine("--------------------");
            Console.WriteLine("{0,-20}{1:20}", cola, colaPrice); // - means left align + means right align // 15 blocks
            Console.WriteLine("--------------------");
            Console.WriteLine("{0,-20}{1:20}", fanta, fantaPrice); // - means left align + means right align // 15 blocks
            Console.WriteLine("{0,-20}{1:20}", pepsi, pepsiPrice); // - means left align + means right align // 15 blocks


            //
            double a = 1.0f; // 1
            double b = 0.33f; //double>float // 0.33000000 +randomnumber
            double sum = 1.33f; // 1.33000000 + random number
            bool equal = (a + b == sum);
            Console.WriteLine("result = a{0} b{1} sum{2} equal{3}", a, b, sum, equal); // false

            byte centruies = 20;
            uint year = 2017;
            uint day = 730480;
            ulong hours = 17531520;
            Console.WriteLine("{0}{1}{2}{3}", centruies, year, day, hours);

            string firstN = "saeko";
            string lastN = "fukui";
            string name = firstN + lastN;
            Console.WriteLine(name);

            string strA = "hello";
            string strB = "h";
            strB += "ello";
            string strC = "hello";
            Console.WriteLine(strA == strB); // true // just compare string value
            Console.WriteLine((object)strA == (object)strB); // false // reference value is different

            Console.WriteLine(strA == strC); // true
            Console.WriteLine((object)strA == (object)strC); // true // reference value is the same

            string path = @"c:\Docs\Sourcce\a.txt"; // we need @
            Console.WriteLine(path); // c:\Docs\Sourcce\a.txt

            object o1;
            o1 = 1;
            Console.WriteLine(o1);
            Console.WriteLine(o1.GetType()); // System.Int32

            int? someInteger = null; // ? = accept null // good for database double? like that
            Console.WriteLine("{0}", someInteger);
            someInteger = 5;
            Console.WriteLine("{0}", someInteger);

            Console.Read();
        }
    }

}