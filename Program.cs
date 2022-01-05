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
            Console.ReadLine();
        }
    }
}
