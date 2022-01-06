using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Console  
             */
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");

            string name = "Shuhao Zhang";
            int age = 23;
            string title = "Full Stack Developer";

            Console.WriteLine("Hi, my name is {0}, I am {1} years old, I am a {2}", name, age, title);

            /*
             * String
             */
            string game = "Dota2";
            string gameUpperCase = game.ToUpper();
            string gameLowerCase = gameUpperCase.ToLower();
            Console.WriteLine(gameUpperCase);
            Console.WriteLine(gameLowerCase);

            char gameFirstCh = game[0];
            int gameIndexOf = game.IndexOf("ta2"); // ta2 starts at index 2 of Dota2
            int nonExistIndex = game.IndexOf('Z'); // -1
            string gameSubstring = game.Substring(0, gameIndexOf);
            Console.WriteLine(gameFirstCh);
            Console.WriteLine(gameIndexOf);
            Console.WriteLine(nonExistIndex);
            Console.WriteLine(gameSubstring);

            /*
             *  Number
             */

            Console.WriteLine(-5.763);

            //https://stackoverflow.com/questions/618535/difference-between-decimal-float-and-double-in-net
            int add = 5 + 8;
            double add2 = 5.7 + 8.7;
            Console.WriteLine(add);
            Console.WriteLine(add2);
            int multiply = 5 * 8;
            Console.WriteLine(multiply);
            int divide = 5 / 8;
            double divide2 = 5.0 / 8;
            float divide3 = 5 / 8;
            Console.WriteLine("int 5/8 is {0}", divide);
            Console.WriteLine("double 5.0/8 is {0}", divide2);
            Console.WriteLine("float 5/8 is {0}", divide3);

            // Math contains almost all the useful Math operations
            double pi = Math.PI;
            Console.WriteLine(pi);
            double maxNumber = Math.Max(pi, 3);
            Console.WriteLine("pi vs 3: {0} is larger", maxNumber);
            double absValue = Math.Abs(-4.56);
            Console.WriteLine("absolute value of -4.56 is {0}",absValue);
            double roundUp = Math.Round(5.5);
            double roundDown = Math.Round(pi);
            Console.WriteLine("5.5 can be rounded up to {0}",roundUp);
            Console.WriteLine("pi can be rounded down to {0}",roundDown);

            // Getting User Inputs
            /*
            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();
            Console.Write("How should I address you? ex: Mr. Mrs. Dr.: ");
            string inputPronoun = Console.ReadLine();
            Console.WriteLine("Hello, {0}. {1}", inputPronoun, inputName);
            Console.ReadLine();
            */

            // Calculator
            /*
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The answer is: {0}", num1 + num2);
            Console.ReadLine();
            */

            // Arrays
            int[] luckyNumbers = { 7, 6, 8, 10 };

            Console.WriteLine(luckyNumbers[0]);

            luckyNumbers[3] = 0;

            Console.WriteLine(luckyNumbers[3]);
            Console.WriteLine(luckyNumbers);
            foreach (var number in luckyNumbers)
            {
                Console.Write(number.ToString());
            }
            Console.Write("\n");

            string[] friends = new string[5]; // This friends array can hold up to 5 values
            friends[0] = "Jim";
            friends[1] = "Kelly";
            Console.WriteLine(friends[1]);

            // Call the Method (Function)
            SayHi("Shuhao");
            double cubedNumber = getCube(10);
            Console.WriteLine(cubedNumber);
            

            // Methods (Functions)
            static void SayHi(string name)
            {
                Console.WriteLine("Hi {0}", name);
            }

            // Return Statement

            static double getCube(int number)
            {
                return Math.Pow(number,3);
            }

            // If statement
            bool isMale = false;

            bool isTall = false;


            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }
            else
            {
                Console.WriteLine("You are a short female");
            }

            static int getMax(int num1, int num2)
            {
                if (num1 == num2)
                {
                    return -1;
                }
                else if (num1 > num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
            Console.WriteLine(getMax(10,5));
            Console.WriteLine(getMax(10,10));

            // a better calculator
            /*
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator:");
            string op = Console.ReadLine();
            Console.Write("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine("Result is {0}", num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine("Result is {0}", num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine("Result is {0}", num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine("Result is {0}", num1 / num2);
            } else
            {
                Console.WriteLine("please enter correct operator: +, -, * or /");
            }
            */

            // Switch Statement
            static string GetDay(int dayNum)
            {
                string dayName;

                switch (dayNum)
                {
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                    case 7:
                        dayName = "Sunday";
                        break;
                    case -1:
                        dayName = "Weekend";
                        break;
                    default:
                        dayName = "Weekday";
                        break;
                }

                return dayName;
            }

            Console.WriteLine(GetDay(7));
            Console.WriteLine(GetDay(-1));
            Console.WriteLine(GetDay(200));

            // While loop
            Console.WriteLine("While loop");
            int j = 0;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j ++;
            }

            // do while loop
            Console.WriteLine("do While loop");
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index ++;
            } while (index < 5);
            // a 6 will be printed out even though it doesn't meet the condition i < 5
            // This is because in a do while loop, it will execute the loop first and then check the condition

            // for loop
            Console.WriteLine("For loop");
            for (int i = 0; i < luckyNumbers.Length; i ++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            /*
            static double GetPow(int baseNum, int powNum)
            {
                return Math.Pow(baseNum, powNum);
            }

            Console.Write("Please enter a base num: ");
            string baseNum = Console.ReadLine();
            Console.Write("Please enter a pow num: ");
            string powNum = Console.ReadLine();
            double result = GetPow(Int32.Parse(baseNum), Int32.Parse(powNum));
            Console.WriteLine(result);
            */

            // 2D array
            int[,] numberGrid =
            {
                { 0, 0 },
                { 1, 0 },
                { 0, 1 },
                { 1, 1 },
            };

            Console.WriteLine(numberGrid[1, 1]);
            Console.ReadLine();
        }
    }
}
