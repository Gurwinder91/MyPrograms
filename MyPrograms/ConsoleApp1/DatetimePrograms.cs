using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class DatetimePrograms
    {
        public static void Age(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Now;

            var yearDifference = currentDate.Year - dateOfBirth.Year;
            int monthDifference, dateDifference = 0;

            if (currentDate.Month < dateOfBirth.Month)
            {
                --yearDifference;
                monthDifference = 12 - (dateOfBirth.Month - currentDate.Month);
            }
            else
            {
                monthDifference = currentDate.Month - dateOfBirth.Month;
            }

            if (currentDate.Day < dateOfBirth.Day)
            {
                dateDifference = 30 - (dateOfBirth.Day - currentDate.Day);
            }
            else
            {
                dateDifference = currentDate.Day - dateOfBirth.Day;
            }

            Console.WriteLine("You are {0} years {1} months {2} days old", yearDifference, monthDifference, dateDifference);
        }

        public static void Age1(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate.Subtract(dateOfBirth);
            DateTime age = DateTime.MinValue + difference;
            int ageInYears = age.Year - 1;
            int ageInMonths = age.Month - 1;
            int ageInDays = age.Day - 1;
            Console.WriteLine("You are {0} years {1} months {2} days old", ageInYears, ageInMonths, ageInDays);
        }
    }
}
