
DateTime date = new DateTime(2026, 9, 25, 10, 0, 0);
TimeSpan diff = date - DateTime.Now;
Console.WriteLine("Day Reamining: " + diff.Days);
Console.WriteLine("Hour Reamining: " + diff.Hours);
Console.WriteLine("Minute Reamining: " + diff.Minutes);
Console.WriteLine("Second Reamining: " + diff.Seconds);

TimeOnly start = new TimeOnly( 9, 0,0);
TimeOnly end = new TimeOnly(18, 30, 0);

Console.WriteLine("Working Hour: " + (end - start));


DateTime startDate = new DateTime(2026, 9, 1, 0, 0, 0);
DateTime endDate = new DateTime(2026, 9, 15, 0, 0, 0);

Console.WriteLine("Difference: " + (endDate - startDate).Days + " Days");
