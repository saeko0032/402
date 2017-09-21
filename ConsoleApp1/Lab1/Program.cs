using System;

namespace Lab1
{
    class Lab1
    {

        static void Main(string[] args)
        {
              Lab1.Task1();
              Lab1.Task2();
              Lab1.Task3();
              Lab1.Task4();
              Lab1.Task5();
              Lab1.Task6();
              Lab1.Task7();
              Lab1.Task8();
              Lab1.Task9();
              Lab1.Task10();
            Console.Read();
        }

        // print hello and my name
        static void Task1()
        {
            Console.WriteLine("Hello\nSaeko");
            Console.WriteLine("----------------------------------\n");
           
        }

        // print 2 numbers calculation
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
            Console.WriteLine("----------------------------------\n");

        }

        // convert celcius to kelvin and fahrenheit
        static void Task3()
        {
            Console.WriteLine("Enter Celsius degrees");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius : {0:000.00} °C Kelvin : {1:000.00} K Fahrenheit : {2:000.00} °F", celsius, celsius + 273, celsius * 1.8 + 32);
            Console.WriteLine("----------------------------------\n");

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
            Console.WriteLine("----------------------------------\n");

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
                else if (97 <= checkLetter[0] && checkLetter[0] <=122 )
                {
                    Console.WriteLine("The letter is neither vowel nor digit");
                }
                else
                {
                    Console.WriteLine("The letter is any other symbol or upper letter");
                }
            }
            Console.WriteLine("----------------------------------\n");
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
            Console.WriteLine("----------------------------------\n");

        }

        // height check
        static void Task7()
        {
            Console.WriteLine("input your height in cm");
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
            Console.WriteLine("----------------------------------\n");

        }

        // calculate root of quadratic equation
        static void Task8()
        {
            int a = -1;
            int b = -1;
            int c = -1;
            double x1, x2;
            Console.WriteLine("input 3 numbers(first num is not 0)");
            a = int.Parse(Console.ReadLine());
            if ( a== 0)
            {
                Console.WriteLine("a should not be 0, bye");
                return;
            }
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int determinant;
            determinant = b * b - 4 * a * c;
            if (determinant == 0)
            {
                Console.WriteLine("the roots are real and equal.");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("first root is {0}", x1);
                Console.WriteLine("second root is {0}", x2);
            }
            else if (determinant > 0)
            {
                Console.WriteLine("the roots are real and different.");
                x1 = ((-b + Math.Sqrt(determinant)) / (2 * a));
                Console.WriteLine("first root is {0}", x1);
                x2 = ((-b - Math.Sqrt(determinant)) / (2 * a));
                Console.WriteLine("second root is {0}", x2);
            }
            else
            {
                Console.WriteLine("the roots are complex and different.");
                x1 = (-b) / (2 * a);
                x2 = Math.Sqrt(-determinant) / (2 * a);
            }
            Console.WriteLine("----------------------------------\n");
        }

        // simple calculation
        static void Task9()
        {
            Console.WriteLine("Enter the first integer");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a option number");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Substraction");
            Console.WriteLine("3 Multiplication");
            Console.WriteLine("4 Division");
            Console.WriteLine("5 Exit");
            int optionNumber = int.Parse(Console.ReadLine());

            switch (optionNumber)
            {
                case 1:
                    Console.WriteLine("The Addition of {0} and {1} is: {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                    break;

                case 2:
                    Console.WriteLine("The Substraction of {0} and {1} is: {2}", firstNumber, secondNumber, firstNumber - secondNumber);
                    break;

                case 3:
                    Console.WriteLine("The Multiplication of {0} and {1} is: {2}", firstNumber, secondNumber, firstNumber * secondNumber);
                    break;

                case 4:
                    Console.WriteLine("The Division of {0} and {1} is: {2}", firstNumber, secondNumber, firstNumber / secondNumber);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("----------------------------------\n");
        }

        // change format example
        static void Task10()
        {
            DateTime today = new DateTime(2017,9,12);
            Console.WriteLine(today.ToString("yyyy-MM-dd")); // 2017-09-12
            Console.WriteLine(today.ToString("dd-MMM-yy")); // 12-Sep-17
            Console.WriteLine(today.ToString("M/dd/yyyy")); // 9/12/2017
            Console.WriteLine(today.ToString("M/dd/yy")); // 9/12/17
            Console.WriteLine(today.ToString("MM/dd/yyyy")); // 09/12/2017
            Console.WriteLine(today.ToString("MM/dd/yy")); // 09/12/17
            Console.WriteLine(today.ToString("yy/MM/dd")); // 17/09/12
            Console.WriteLine("----------------------------------\n");
        }
    }
}
