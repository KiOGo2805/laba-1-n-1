using System;

class Program
{
    static void Main()
    {
        double x, y;
        Console.WriteLine("Введіть координату x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть координату y:");
        y = Convert.ToDouble(Console.ReadLine());

        double a = 5;
        double b = 3;
        double R = 3.5;

        bool insideCircle = (x * x + y * y < R * R);
        bool onCircle = (x * x + y * y == R * R);


        bool insideRectangleUp = (x >= -a && x <= a && y >= -b && y <= b);
        bool insideRectangleDown = (x >= -a && x <= a && y >= -b && y <= b);


        if (insideRectangle && insideCircle)
        {
            Console.WriteLine("Так");
        }
        else if (insideRectangle && !insideCircle)
        {
            Console.WriteLine("Ні");
        }
        else
        {
            Console.WriteLine("На межі");
        }
    }
}
