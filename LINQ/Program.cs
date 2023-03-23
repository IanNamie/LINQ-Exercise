using System;
using LINQ;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*reate a list of video game names...
            Order the list of games by length of the game name.
            Use the lambda expression in this exercise as well.
            Use Method Syntax for this exercise*/

            List<string> GameName = new List<string>();
            GameName.Add("Elden Ring");
            GameName.Add("Modern Warfare 2");
            GameName.Add("For Honor");

           var orderedGameName = GameName.OrderBy(name  => name.Length);
            foreach (string name in orderedGameName) 
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("_____________________________________________________________");
            var orderedGameName1 = GameName.OrderByDescending(name => name.Length);
            foreach (string name1 in orderedGameName1) 
            {
                Console.WriteLine(name1);
            }
        }
    }
}
