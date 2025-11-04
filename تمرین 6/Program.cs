// tamri 6
// Amirhossein Mohammadi

using System;

class Program
{
    static void Main()
    {
        double sum = 0;
        double totalWeight = 0;

        while (true)
        {
            Console.Write("adad ra vared konid va bad az vared kard tamam adad ba vazneshan exit ra vard konid");
            string input = Console.ReadLine();

            if (input == "exit")
                break;

            double number = double.Parse(input);

            Console.Write("vazne adad ra vared konid");
            double weight = double.Parse(Console.ReadLine());

            sum = sum + (number * weight);
            totalWeight = totalWeight + weight;
        }

        if (totalWeight > 0)
        {
            double average = sum / totalWeight;
            Console.WriteLine("miyangin vazn dar = " + average);
        }
        else
        {
            Console.WriteLine("vazni vared nashode ast");
        }
    }
}
