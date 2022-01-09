using System.Globalization;

DateTime dt = DateTime.ParseExact("3/01/1964", "M/dd/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(dt);
Console.ReadLine();
