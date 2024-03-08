// Year, Month, Day, Hour, Min, Sec
DateTime dt = new DateTime(2024, 2, 24, 1, 2, 3);

Console.WriteLine(dt.ToString("yy-mm-ss"));
Console.WriteLine(dt.ToLongDateString());
Console.WriteLine(dt.ToShortDateString());
Console.WriteLine(dt.ToLongTimeString());
Console.WriteLine(dt.ToShortTimeString());

// Hour, Minutes, Seconds
TimeSpan t1 = new TimeSpan(1, 2, 3);
TimeSpan t2 = TimeSpan.FromHours(1);

Console.WriteLine(t1.Add(t2));
Console.WriteLine(t1.Minutes);
Console.WriteLine(t1.TotalMinutes);


Console.WriteLine(TimeSpan.Parse("1:2:3"));
