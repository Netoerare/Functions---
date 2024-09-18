using System;

public class Function2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        string result = LeapYr(year);
        Console.WriteLine(result);
    }

    public static string LeapYr(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                return "Year is a leap year.";
            }
        }
        return "Year is not a leap year.";
    }
}
