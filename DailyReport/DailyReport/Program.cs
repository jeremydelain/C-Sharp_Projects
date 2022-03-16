using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //collect the student's name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //collect student's current course
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            //collect page student is working on
            Console.WriteLine("What page number?");
            int pageNumber = int.Parse(Console.ReadLine());

            //collect if student needs help as T/F
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = bool.Parse(Console.ReadLine());

            //collect student experience
            Console.WriteLine("Were there any positive expereinces you'd like to provide? Please be specific.");
            string expereiences = Console.ReadLine();

            //collect hours studied
            Console.WriteLine("How many hours did you study today?");
            float hoursStudied = float.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
