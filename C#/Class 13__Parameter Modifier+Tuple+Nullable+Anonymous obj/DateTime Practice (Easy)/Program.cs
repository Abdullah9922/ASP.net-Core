

DateTime current = DateTime.Now;
Console.WriteLine("Current Date & Time: " + current);
Console.WriteLine("Current Date: " + current.Date);
Console.WriteLine("Current Time: " + current.TimeOfDay);

DateTime date = new DateTime(2026, 9, 15, 18, 30, 45);
Console.WriteLine(date.Date);
Console.WriteLine(date.TimeOfDay);
Console.WriteLine($"{date.DayOfWeek}, {date.Month} , {date.Year}");

Console.WriteLine("Input Your Birthday: (YYYY-MM-DD)");

string[] date2 = Console.ReadLine()!.Split('-');

int day = int.Parse(date2[2]);
int month = int.Parse(date2[1]);
int year = int.Parse(date2[0]);

DateTime birthday = new DateTime(year, month, day);
DateTime now = DateTime.Now;

// Age
int age = now.Year - birthday.Year;

if (now.Month < birthday.Month ||
    (now.Month == birthday.Month && now.Day < birthday.Day))
{
    age--;
}

Console.WriteLine($"Age: {age}");

// Next Birthday
DateTime nextBirthday = new DateTime(
    now.Year,
    birthday.Month,
    birthday.Day
);

if (nextBirthday <= now)
{
    nextBirthday = nextBirthday.AddYears(1);
}

TimeSpan remaining = nextBirthday - now;

Console.WriteLine($"Next Birthday: {nextBirthday:yyyy-MM-dd}");
Console.WriteLine($"Days Remaining: {remaining.Days}");