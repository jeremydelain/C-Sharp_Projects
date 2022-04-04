using System;
using System.Threading;

namespace WhileStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number of seconds to start a timer:");
            int seconds = int.Parse(Console.ReadLine());
            do
            {
                Thread.Sleep(1000);
                seconds--;
                Console.WriteLine(seconds.ToString());
            } while (seconds > 0);

            Console.WriteLine("Guess what number I'm thinking of between 1 and 5");
            Random rnd = new Random();
            int secretNum = rnd.Next(1, 6);
            int guess = int.Parse(Console.ReadLine());
            while (guess != secretNum)
            {
                Console.WriteLine("INCORRECT");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("CORRECT :)");
            Thread.Sleep(5000);
        }
    }
}
