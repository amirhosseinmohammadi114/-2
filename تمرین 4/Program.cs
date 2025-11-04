// tamrin 4
// Amirhossein Mohammadi

using System;

class Program
{
    static void Main()
    {
        // دریافت مختصات سه نقطه از کاربر
        Console.WriteLine("مختصات نقطه P1:");
        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("مختصات نقطه P2:");
        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("مختصات نقطه P3:");
        Console.Write("x3 = ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("y3 = ");
        double y3 = double.Parse(Console.ReadLine());

        // بررسی هم‌خط بودن با استفاده از دترمینان
        double value = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);

        if (value == 0)
            Console.WriteLine("P1P2 roye khati ke az P3 migozarad ghrar DARAD");
        else
            Console.WriteLine("P1P2 roye khati ke az P3 migozarad ghrar NADARAD");
    }
}