using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate a List of Employee with 10 entries
            List<Employee> empList = new List<Employee>();

            Employee one = new Employee("Joe", "Mama", 1);
            empList.Add(one);

            Employee two = new Employee("Joe", "Schmo", 2);
            empList.Add(two);

            Employee three = new Employee("Thomas", "Thetankengine", 3);
            empList.Add(three);

            Employee four = new Employee("Spider", "Man", 4);
            empList.Add(four);

            Employee five = new Employee("Lightning", "McQueen", 5);
            empList.Add(five);

            Employee six = new Employee("Gabriel", "Buktus", 6);
            empList.Add(six);

            Employee seven = new Employee("Cedrick", "Highsmith", 7);
            empList.Add(seven);

            Employee eight = new Employee("Douglas", "Bubbletrousers", 8);
            empList.Add(eight);

            Employee nine = new Employee("Candice", "Redacted", 9);
            empList.Add(nine);

            Employee ten = new Employee("Chuck", "E. Cheese", 10);
            empList.Add(ten);


            //find Joe's with foreach
            Console.WriteLine("Find 2 Joe's with foreach:");
            List<Employee> joe = new List<Employee>();
            foreach(Employee item in empList)
            {
                if(item.firstName == "Joe")
                {
                    joe.Add(item);
                }
            }
            //confirm Joe's were found
            foreach (Employee item in joe)
            {
                Console.WriteLine(item.firstName + " " + item.lastName + ", ID: " + item.Id);
            }


            //find Joe's with lambda
            Console.WriteLine("Find 2 Joe's with lambda:");
            List<Employee> joe2 = joe.Where(x => x.firstName == "Joe").ToList();
            //confirm Joe's were found
            foreach (Employee item in joe2)
            {
                Console.WriteLine(item.firstName + " " + item.lastName + ", ID: " + item.Id);
            }


            //find employees with ID > 5
            Console.WriteLine("Find employees with an ID number greater than 5:");
            List<Employee> id5 = empList.Where(x => x.Id > 5).ToList();
            //confirm employees with ID > 5 were found
            foreach (Employee item in id5)
            {
                Console.WriteLine(item.firstName + " " + item.lastName + ", ID: " + item.Id);
            }
            Console.ReadLine();
        }
    }
}
