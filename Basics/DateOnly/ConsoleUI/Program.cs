DateTime now = DateTime.Now;
DateOnly today = DateOnly.FromDateTime(now);

Console.WriteLine(today.ToString("M/dd/yy"));

Console.ReadLine();