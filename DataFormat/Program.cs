using System;

namespace DataFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program retrieves the current date and displays it in different ways");

            DateTime currentDate = DateTime.Today;
            Console.WriteLine("Today is {0}", currentDate.ToString());
            Console.WriteLine("Display the date in different formats:");
            Console.WriteLine(currentDate.ToString("d"));
            Console.WriteLine(currentDate.ToString("D"));
            Console.WriteLine(currentDate.ToString("g"));

            Console.ReadKey();
        }
    }
}
