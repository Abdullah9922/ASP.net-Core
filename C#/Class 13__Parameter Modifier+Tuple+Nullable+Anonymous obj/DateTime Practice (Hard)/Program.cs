
DateTime meeting = new DateTime(26, 09, 20, 14, 30, 0);
DateTime now = DateTime.Now;

if (meeting.Equals(now)) Console.WriteLine("Today.");
else if (now > meeting) Console.WriteLine("Passed");
else Console.WriteLine("Future");

Console.WriteLine("Enter your Bithday: ");
Console.Write("Year: ");
int year = int.Parse(Console.ReadLine());
Console.Write("Month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Day: ");
int day = int.Parse(Console.ReadLine());

DateTime birthday = new DateTime(year, month, day);
TimeSpan diff = (now-birthday);

Console.WriteLine($"Age: {(int)(diff.TotalDays/30)/12} years, {(int)diff.TotalDays / 30} months, {(int)diff.Days} days");
Console.WriteLine($"Total Days Lived: {diff.TotalDays} days");

if(now.Month <= birthday.Month)
{
    Console.WriteLine($"Next Birthday: {diff.TotalDays} days remaining");
}
else
{
    Console.WriteLine("Akono onk time ase je vai. next year");
}


Console.Write("Enter Year: ");
int year2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter Month: ");
int month2 = int.Parse(Console.ReadLine()!);

DateTime firstDay = new DateTime(year2, month2, 1);

int daysInMonth = DateTime.DaysInMonth(year2, month2);

DateTime lastDay = new DateTime(
    year2,
    month2,
    daysInMonth
);

Console.WriteLine();

Console.WriteLine($"Month: {firstDay:MMMM yyyy}");
Console.WriteLine($"Total Days: {daysInMonth}");
Console.WriteLine($"First Day: {firstDay:dddd}");
Console.WriteLine($"Last Day: {lastDay:dddd}");
