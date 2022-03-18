using System;
using System.Collections.Generic;
using System.Threading;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //instantiate 2 arrays and a list
            string[] stringArray = new string[] { "zero", "one", "two", "three", "four", "five" };
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5 };
            List<string> stringList = new List<string>()
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five"
            };

            //get user index
            Console.WriteLine("Enter an index between 0 and 5 for corresponding string:");
            int userIndex = int.Parse(Console.ReadLine());

            //validate input
            if (userIndex < 0 || userIndex > 5)
            {
                Console.WriteLine("Outside of acceptable range!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            } else //return string at user index
            {
                Console.WriteLine(stringArray[userIndex]);
            }
            

            //get user index
            Console.WriteLine("Enter an index between 0 and 5 for corresponding int:");
            userIndex = int.Parse(Console.ReadLine());

            //validate input
            if (userIndex < 0 || userIndex > 5)
            {
                Console.WriteLine("Outside of acceptable range!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            } else //return int at user index
            {
                Console.WriteLine(intArray[userIndex]);
            }


            //get user index
            Console.WriteLine("Enter an index between 0 and 5 for list index:");
            userIndex = int.Parse(Console.ReadLine());

            //validate input
            if (userIndex < 0 || userIndex > 5)
            {
                Console.WriteLine("Outside of acceptable range!");
                Thread.Sleep(5000);
                Environment.Exit(0);
            } //return string at user index from list
            else
            {
                Console.WriteLine(stringList[userIndex]);
            }

            Console.ReadLine();
        }
    }
}
