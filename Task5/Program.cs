using System;

class Task5
{
    static void Main()
    {
        // 1. Birthdate and Current Date
        DateTime birthdate = new DateTime(2002, 5, 15);
        DateTime currentDate = DateTime.Now;

        // 2. Calculate age using TimeSpan
        TimeSpan ageSpan = currentDate - birthdate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        // 3. Print values
        Console.WriteLine($"Birthdate: {birthdate:yyyy-MM-dd}");
        Console.WriteLine($"Current Date: {currentDate:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"Age: {ageInYears} years");

        // 4. Add 10 days to birthdate
        DateTime birthdatePlus10Days = birthdate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 Days: {birthdatePlus10Days:yyyy-MM-dd}");
    }
}