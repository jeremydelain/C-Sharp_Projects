using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>()
            {
                "here ",
                "are ",
                "some ",
                "words "
            };

            List<string> presidentList = new List<string>()
            {
                "Jimmy Carter",
                "Bill Clinton",
                "George W. Bush",
                "Barack Obama",
                "Donald Trump"
            };

            List<string> colors = new List<string>()
            {
                "red", "orange", "yellow", "green", "blue",
                "violet", "red", "red", "green", "blue",
                "indigo", "orange", "indigo", "violet", "yellow"
            };

            //add user input to each string in the list and print it
            Console.WriteLine("Enter a word or words to append to my strings:");
            string userInput = Console.ReadLine();
            for (int i = 0; i < stringList.Count; i++)
            {
                stringList[i] += userInput;
            }
            foreach (string element in stringList)
            {
                Console.WriteLine(element);
            }


            //infinite loop fixed to interate once
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("TRUE");
                loop = false;
            }


            //loop with < comparison
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            //loop with <= comparison
            for(int i = 0; i <= 6; i++)
            {
                Console.WriteLine(i);
            }


            //user enters first/last name of the previous 5 presidents and returns the index in the list
            Console.WriteLine("Enter the name of one of the five previous US Presidents:");
            string userPresident = Console.ReadLine();

            for(int i = 0; i < presidentList.Count; i++)
            {
                if (presidentList[i].Contains(userPresident))
                {
                    Console.WriteLine("President located at index " + i);
                    i = presidentList.Count;
                }
            }
            if (!presidentList.Contains(userPresident))
            {
                Console.WriteLine("Entry either misspelled or not in the list");
            }


            //user enters a color in the rainbow and returns indecies where color is found
            Console.WriteLine("Enter a color in the rainbow:");
            string userColor = Console.ReadLine();
            for(int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Contains(userColor))
                {
                    Console.WriteLine("Color located at index " + i);
                }
            }
            if (!colors.Contains(userColor))
            {
                Console.WriteLine("Color either misspelled or not in the rainbow");
            }




            //tracks elements as the string is iterated for repeated entries
            List<string> containsColor = new List<string>() { };
            foreach (string element in colors)
            {
                if (!containsColor.Contains(element))
                {
                    containsColor.Add(element);
                    Console.WriteLine(element + " HAS NOT already appeared in the list");
                }
                else
                {
                    Console.WriteLine(element + " HAS already appeared in the list");
                }
            }
            Console.ReadLine();
        }
    }
}
