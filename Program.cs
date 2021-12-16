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



            Console.ReadLine();
        }
    }
}
