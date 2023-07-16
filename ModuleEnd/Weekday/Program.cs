using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            // LINQ query to select the days of the week.
            var days = from day in daysOfWeek select day;

            // Iterate through the days of the week
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}