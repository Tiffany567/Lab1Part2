using System;
using System.Globalization;

namespace LabPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat1 = true;
            CultureInfo culture = new CultureInfo("en-US");

                Console.WriteLine("Compare the difference between two dates (MM/dd/yyyy)");
                while (repeat1 == true)
                {
                    DateTime date1, date2;
                    Console.WriteLine("Enter the first date:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date1))
                    {
                        repeat1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat1 = true;

                    }

                    Console.WriteLine("Enter the second date:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                    {
                        repeat1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat1 = true;
                    }
                        TimeSpan subtractDates = date2 - date1;
                        var dayDiff = subtractDates.Days;
                        var hoursDiff = dayDiff * 24;
                        var minDiff = hoursDiff * 60;
                        Console.WriteLine("The difference between the two dates is {0} days = {1} hours = {2} minutes.", dayDiff, hoursDiff, minDiff);
                }
                
        



        }

    }
}
