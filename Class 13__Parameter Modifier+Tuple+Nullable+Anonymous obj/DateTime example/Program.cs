using System;

class Program
{
    static void Main()
    {
        // ==========================================
        // 1. Current Date and Time
        // ==========================================

        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date & Time: " + now);
        Console.WriteLine("Current Date: " + now.Date);
        Console.WriteLine("Current Time: " + now.TimeOfDay);

        Console.WriteLine();


        // ==========================================
        // 2. UTC Time
        // ==========================================

        DateTime utcNow = DateTime.UtcNow;

        Console.WriteLine("UTC Time: " + utcNow);

        Console.WriteLine();


        // ==========================================
        // 3. Creating a Specific Date
        // ==========================================

        DateTime birthDate = new DateTime(2003, 5, 15);

        Console.WriteLine("Birth Date: " + birthDate);

        Console.WriteLine();


        // ==========================================
        // 4. Creating Date + Time
        // ==========================================

        DateTime meeting = new DateTime(
            2026,
            9,
            20,
            14,
            30,
            0
        );

        Console.WriteLine("Meeting: " + meeting);

        Console.WriteLine();


        // ==========================================
        // 5. Getting Individual Parts
        // ==========================================

        Console.WriteLine("Year: " + meeting.Year);
        Console.WriteLine("Month: " + meeting.Month);
        Console.WriteLine("Day: " + meeting.Day);

        Console.WriteLine("Hour: " + meeting.Hour);
        Console.WriteLine("Minute: " + meeting.Minute);
        Console.WriteLine("Second: " + meeting.Second);

        Console.WriteLine("Day of Week: " + meeting.DayOfWeek);
        Console.WriteLine("Day of Year: " + meeting.DayOfYear);

        Console.WriteLine();


        // ==========================================
        // 6. Adding Days
        // ==========================================

        DateTime today = DateTime.Now;

        DateTime after7Days = today.AddDays(7);

        Console.WriteLine("Today: " + today);
        Console.WriteLine("After 7 Days: " + after7Days);

        Console.WriteLine();


        // ==========================================
        // 7. Adding Months / Years
        // ==========================================

        DateTime date = new DateTime(2026, 9, 15);

        Console.WriteLine("Original: " + date);
        Console.WriteLine("After 1 Month: " + date.AddMonths(1));
        Console.WriteLine("After 1 Year: " + date.AddYears(1));

        Console.WriteLine();


        // ==========================================
        // 8. Subtracting Days
        // ==========================================

        Console.WriteLine("Before 10 Days: " + date.AddDays(-10));
        Console.WriteLine("Before 2 Months: " + date.AddMonths(-2));

        Console.WriteLine();


        // ==========================================
        // 9. Comparing Dates
        // ==========================================

        DateTime date1 = new DateTime(2026, 9, 10);
        DateTime date2 = new DateTime(2026, 9, 20);

        if (date1 < date2)
        {
            Console.WriteLine("date1 is before date2");
        }

        if (date2 > date1)
        {
            Console.WriteLine("date2 is after date1");
        }

        if (date1 == date2)
        {
            Console.WriteLine("Both dates are same");
        }

        Console.WriteLine();


        // ==========================================
        // 10. Date Difference
        // ==========================================

        DateTime startDate = new DateTime(2026, 9, 1);
        DateTime endDate = new DateTime(2026, 9, 15);

        TimeSpan difference = endDate - startDate;

        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Days: " + difference.Days);

        Console.WriteLine();


        // ==========================================
        // 11. Time Difference
        // ==========================================

        DateTime startTime =
            new DateTime(2026, 9, 15, 10, 0, 0);

        DateTime endTime =
            new DateTime(2026, 9, 15, 13, 30, 0);

        TimeSpan timeDifference = endTime - startTime;

        Console.WriteLine("Hours: " + timeDifference.TotalHours);
        Console.WriteLine("Minutes: " + timeDifference.TotalMinutes);

        Console.WriteLine();


        // ==========================================
        // 12. Formatting DateTime
        // ==========================================

        DateTime current = DateTime.Now;

        Console.WriteLine(
            current.ToString("dd-MM-yyyy")
        );

        Console.WriteLine(
            current.ToString("dd/MM/yyyy")
        );

        Console.WriteLine(
            current.ToString("yyyy-MM-dd")
        );

        Console.WriteLine(
            current.ToString("dd MMMM yyyy")
        );

        Console.WriteLine();


        // ==========================================
        // 13. Formatting Time
        // ==========================================

        Console.WriteLine(
            current.ToString("HH:mm:ss")
        );

        Console.WriteLine(
            current.ToString("hh:mm:ss tt")
        );

        Console.WriteLine();


        // ==========================================
        // 14. Parse String → DateTime
        // ==========================================

        string dateString = "15-09-2026";

        DateTime parsedDate =
            DateTime.Parse(dateString);

        Console.WriteLine("Parsed Date: " + parsedDate);

        Console.WriteLine();


        // ==========================================
        // 15. TryParse
        // ==========================================

        string input = "20-09-2026";

        if (DateTime.TryParse(input, out DateTime result))
        {
            Console.WriteLine("Valid Date: " + result);
        }
        else
        {
            Console.WriteLine("Invalid Date");
        }

        Console.WriteLine();


        // ==========================================
        // 16. Checking Leap Year
        // ==========================================

        int year = 2028;

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine(year + " is a leap year");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year");
        }

        Console.WriteLine();


        // ==========================================
        // 17. Days in a Month
        // ==========================================

        int days =
            DateTime.DaysInMonth(2026, 2);

        Console.WriteLine(
            "Days in February: " + days
        );

        Console.WriteLine();


        // ==========================================
        // 18. Date Validation
        // ==========================================

        int inputYear = 2026;
        int inputMonth = 2;
        int inputDay = 30;

        if (inputMonth >= 1 &&
            inputMonth <= 12 &&
            inputDay >= 1 &&
            inputDay <= DateTime.DaysInMonth(
                inputYear,
                inputMonth))
        {
            Console.WriteLine("Valid Date");
        }
        else
        {
            Console.WriteLine("Invalid Date");
        }
    }
}