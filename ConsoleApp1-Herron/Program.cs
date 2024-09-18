using System;

public class Function
{
    public static void Main(string[] args)
    {
        Console.Write("Input 1st side of the triangle: ");
        int Side1st = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 2nd side of the triangle: ");
        int Side2nd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 3rd side of the triangle: ");
        int Side3rd = Convert.ToInt32(Console.ReadLine());

        double FinalArea = Heron(Side1st, Side2nd, Side3rd);

        Console.WriteLine("The area of the triangle is: " + FinalArea);
    }

    public static double Heron(int Side1st, int Side2nd, int Side3rd)
    {
        double Perimeter = (Side1st + Side2nd + Side3rd) / 2.0;

        double Area = Perimeter * (Perimeter - Side1st) * (Perimeter - Side2nd) * (Perimeter - Side3rd);

        return Math.Sqrt(Area);
    }
}
