// tamrin 7
// Amirhossein Mohammadi

using System;

class Program
{
    static void Main()
    {
        Console.Write("adad asli ra vared konid");
        int main = int.Parse(Console.ReadLine());

        Console.Write("adad avval ra vared konid");
        int a = int.Parse(Console.ReadLine());

        Console.Write("adad dovvom ra vared konid");
        int b = int.Parse(Console.ReadLine());

        Console.Write("adad sevvom ra vared konid");
        int c = int.Parse(Console.ReadLine());

        int d1 = Math.Abs(main - a);
        int d2 = Math.Abs(main - b);
        int d3 = Math.Abs(main - c);

        int closest = (d1, d2, d3) switch
        {
            var (x, y, z) when x <= y && x <= z => a,
            var (x, y, z) when y <= x && y <= z => b,
            _ => c
        };

        Console.WriteLine("nazdik tarin adad be adad asli" + closest);
    }
}
