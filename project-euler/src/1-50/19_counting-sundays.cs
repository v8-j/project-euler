// You are given the following information, but you may prefer to do some 
// research for yourself.
// 1 Jan 1900 was a Monday.
// Thirty days has September,
// April, June and November.
// All the rest have thirty-one,
// Saving February alone,
// Which has twenty-eight, rain or shine.
// And on leap years, twenty-nine.
// A leap year occurs on any year evenly divisible by 4, but not on a century
// unless it is divisible by 400.
// How many Sundays fell on the first of the month during the twentieth century 
// (1 Jan 1901 to 31 Dec 2000)?

// Probably (certainly) not the most efficient or best way to do it, but im 
// gonna loop through day by day
using System.Runtime.CompilerServices;

class Counting_Sundays
{
    static string [] days = {"Monday", "Tuesday", "Wednesday", 
    "Thursday", "Friday", "Saturday", "Sunday"};

    static string [] months = {"January", "February", "March", "April",
    "May", "June", "July", "August", "September", "October", "November",
    "December"};

    public static void Run()
    {

        int nrSundayFirsts = 0;

        int year = 1900;
        int month = 1;
        int day = 1;
        int dayOfWeek = 1;
        bool isLeap = true;

        while (year < 2001)
        {
            // on the first day of the year, determine if this year is a leap year
            if (day == 1 && month == 1)
            {
                // Console.WriteLine($"{days[dayOfWeek-1]} {day} {months[month-1]} {year}");
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    isLeap = true;
                else
                    isLeap = false;
            }

            // check if its Sunday the 1st of any month  
            if (day == 1 && dayOfWeek == 7) 
            {
                // We are given start day in 1900, but only want to count from 
                // 1901. Alternatively, we could have found out what day of the
                // week it was on the 1 Jan 1901
                if (year >= 1901) 
                    ++nrSundayFirsts;
            }
            // incrememnt the day of the week
            ++dayOfWeek;
            if (dayOfWeek > 7)
                dayOfWeek = 1;

            // incrememnt the date
            day++;

            // februrary
            if (month == 2)
            {
                if (isLeap)
                {
                    if (day > 29)
                    {
                        day = 1;
                        ++month;
                    }
                }
                else
                {
                    if (day > 28)
                    {
                        day = 1;
                        ++month;
                    }
                }
            }           
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {    // april, june, september, november
                if (day > 30)
                {
                    day = 1;
                    ++month;
                }
            }
            else if (month != 12) // other months = 31 days
            {
                if (day > 31)
                {
                    day = 1;
                    ++month;
                }
            }
            else // its decemeber
            {
                if (day > 31)
                {
                    day = 1;
                    month = 1;
                    ++year;
                }
            }
        }

        Console.WriteLine($"There were {nrSundayFirsts} occasions between 1 "
        + "Jan 1901 and 31 Dec 2000 where the first of the month fell on a "
        + "Sunday!");

    }
}