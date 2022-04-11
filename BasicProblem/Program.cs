using System;
namespace BasicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program");
            bool end = true;
            Console.WriteLine("1.Leap Year\n 2.End the Program");
            while (end == true)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckLeapYear();
                        break;
                    case 2:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;
                }
            }
        }
    }
}