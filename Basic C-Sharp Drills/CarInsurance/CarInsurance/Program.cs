using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            //collect user age
            Console.WriteLine("What is your age?");
            int userAge = int.Parse(Console.ReadLine());

            //collect user dui as T/F
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = bool.Parse(Console.ReadLine());

            //collect number of tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine((userAge >= 15 && !dui && tickets <= 3));
            Console.ReadLine();
        }
    }
}
