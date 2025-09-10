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
        double R = 4;

        bool onCircle = (x * x + y * y == R * R);
        bool insideCircle = (x * x + y * y < R * R);
        if (onCircle)
        {
            bool insideRectangle = (x < 0 && y < 0 && y > (-b));
            тута дальше вивід
            return;
        }

        bool onRectangle = (x == a && y <= b && y >= 0) || (y == b && x <= a) || (y == 0 && x <= a);


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
