using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1, date2;
            bool repeat1 = true, repeat2 = true, repeat3 = true;
            CultureInfo culture = new CultureInfo("en-US");
            char response;

            while (repeat1 == true)
            {
                Console.WriteLine("Enter two dates (MM/dd/yyyy)");

                while (repeat2 == true)
                {
                    Console.WriteLine("Date 1:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date1))
                    {
                        repeat2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat2 = true;

                    }
                }
                while (repeat3 == true)
                {
                    Console.WriteLine("Date 2:");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                    {
                        repeat3 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the date in MM/dd/yyyy format.");
                        repeat3 = true;
                    }
                }

                Console.WriteLine("Would you like to run this program again? (Y or N)");
                response =Convert.ToChar(Console.ReadLine());
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
