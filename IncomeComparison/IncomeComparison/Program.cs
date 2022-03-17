using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparision Program");

            //collect input from user 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            float person1rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            float person1hours = float.Parse(Console.ReadLine());

            //collect input from user 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            float person2rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            float person2hours = float.Parse(Console.ReadLine());

            //calculate annual salary and return for user 1
            Console.WriteLine("Annual salary of Person 1:");
            float salary1 = person1rate * person1hours * 50;
            Console.WriteLine(salary1.ToString());

            //calculate annual salary and return for user 2
            Console.WriteLine("Annual salary of Person 2:");
            float salary2 = person2rate * person2hours * 50;
            Console.WriteLine(salary2.ToString());

            //determine whether user 1 outearns user 2
            Console.WriteLine("Does Person 1 make more money that Person 2?");
            Console.WriteLine((salary1 > salary2).ToString());

            Console.ReadLine();
        }
    }
}
