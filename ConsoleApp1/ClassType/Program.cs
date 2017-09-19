using System;

namespace ClassType
{
    // declare delegates outside of a class
    delegate double MathAction(double num);

    class Program : SampleInterface // : interfacename (java) implemets
    {

        static void Main(string[] args)
        {
            Person p1 = new Person("saeko", 40);
            Person p2 = new Person("maiko", 30);

            //class
            p1.Print();
            p2.Print();
            // interface
            SampleInterface sample = new Program(); // !!! difficult...!!!
            sample.SampleMethod();
            // delegate
            // create an instance for delegate with name method
            MathAction m1 = Multiplication; // DelegateName valiable = MethodName
            MathAction m2 = MakingSquare;
            MathAction m3 = delegate (double input)
            {
                return input * input;
            };

            double ans = m1(4.5);
            double ans2 = m2(3);
            Console.WriteLine(ans);
            Console.WriteLine(ans2);


            Console.Read();
        }

        public void SampleMethod()
        {
            Console.WriteLine("hi");
        }

        // create a method that mathces signature of delegate
        static double Multiplication(double input)
        {
            return input * 2;
        }
        static double MakingSquare(double input)
        {
            return input * input;
        }
    }

}
