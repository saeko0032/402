using System;

namespace Lab1
{
    class Lab1
    {

        static void Main(string[] args)
        {
            //  Lab1.Task1();
            //  Lab1.Task2();
            //  Lab1.Task3();
            //  Lab1.Task4();
            //  Lab1.Task5();
            // Lab1.Task6();
            // Lab1.Task7();
            Lab1.Task8();
            Console.Read();
        }
        // print hello and my name
        static void Task1()
        {
            Console.WriteLine("Hello\nSaeko");
           
        }

        // print output by using 2 numbers
        static void Task2()
        {
            Console.WriteLine("Please input first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please input second number");
            string input2 = Console.ReadLine();
            int firstNum = -1;
            int secondNum = -1;
            try
            {
                firstNum = Convert.ToInt32(input1);
                secondNum = Convert.ToInt32(input2);
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
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
                Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                Console.WriteLine("{0} x {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                Console.WriteLine("{0} mod {1} = {2}", firstNum, secondNum, firstNum % secondNum);
            }
        }

        // convert celcius to kelvin and fahrenheit
        static void Task3()
        {
            Console.WriteLine("Enter Celsius degrees");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius : {0:000.00} °C Kelvin : {1:000.00} K Fahrenheit : {2:000.00} °F", celsius, celsius + 273, celsius * 1.8 + 32);
        }

        // reverse input letters
        static void Task4()
        {
            int maxLength = 3;
            Console.WriteLine("input three letters");
            string threeLetters = Console.ReadLine();
            if (threeLetters.Length > maxLength)
            {
                Console.WriteLine("You input more than 3 letters, bye");
            }
            else
            {
                char[] charArray= threeLetters.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine("input letters : {0} reverse letters : {1}", threeLetters, new string(charArray));
            }
        }

        // check input character
        static void Task5()
        {
            Console.WriteLine("input lowercase character");
            int maxLength = 1;
            string letter = Console.ReadLine();
            if (letter.Length > maxLength)
            {
                Console.WriteLine("You input more than 1 letter, bye");
            }
            else
            {
                char[] checkLetter = letter.ToCharArray();
                if (48 <= checkLetter[0] && checkLetter[0] <= 57)
                {
                    Console.WriteLine("The letter is digit");
                }
                else if (checkLetter[0] == 97 || checkLetter[0] == 101
                  || checkLetter[0] == 105 || checkLetter[0] == 111 || checkLetter[0] == 117)
                {
                    Console.WriteLine("The letter is vowel");
                }
                else
                {
                    Console.WriteLine("The letter is any other symbol or upper letter");
                }
            }
        }

        // even or odd
        static void Task6()
        {
            Console.WriteLine("input positive number within 65535");
            ushort input = ushort.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("input number({0}) is even.", input);
            }
            else
            {
                Console.WriteLine("input number({0}) is odd.", input);
            }
        }

        // height check
        static void Task7()
        {
            Console.WriteLine("inputyour height in cm");
            ushort height = ushort.Parse(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (150 <= height && height < 165)
            {
                Console.WriteLine("Average Height");
            }
            else if (165 <= height && height < 295)
            {
                Console.WriteLine("Taller");
            }
            else
            {
                Console.WriteLine("Abnormale Height");
            }
        }

        static void Task8()
        {
            int a = -1;
            int b = -1;
            int c = -1;
            Console.WriteLine("input 3 numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int determinant;
            determinant = b * b - 4 * a * c;

            if (determinant < 0)
            {
                Console.WriteLine("the roots are complex and different.");
            }
            else if (determinant == 0)
            {
                Console.WriteLine("the roots are real and equal.");
            }
            else
            {
                Console.WriteLine("the roots are real and different.");

            }
        }
    }
}
