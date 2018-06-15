using System;
using System.Globalization;

namespace LabPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat1 = true, repeat2 = true;
            CultureInfo culture = new CultureInfo("en-US");
            char response;

            while (repeat1 == true)
            {
                Console.WriteLine("Compare the difference between two dates (MM/dd/yyyy)");
                while (repeat2 == true)
                {
                    DateTime date1, date2;
                    Console.WriteLine("Enter the first date:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date1))
                    {
                        repeat2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat2 = true;

                    }

                    Console.WriteLine("Enter the second date:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                    {
                        repeat2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat2 = true;
                    }
                        TimeSpan subtractDates = date2 - date1;
                        var dayDiff = subtractDates.Days;
                        var hoursDiff = dayDiff * 24;
                        var minDiff = hoursDiff * 60;
                        Console.WriteLine("The difference between the two dates is {0} days = {1} hours = {2} minutes.", dayDiff, hoursDiff, minDiff);
                }
            Console.WriteLine("Would you like to run this program again? (Y or N)");
            response = Convert.ToChar(Console.ReadLine());
               if (response == 'Y' || response == 'y')
                    {
                        repeat1 = true;
                    }
                    else
                    {
                        repeat1 = false;
                    }
                
            }



        }

    }
}
