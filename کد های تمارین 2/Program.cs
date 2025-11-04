// tamrin 1
// Amirhossein Mohammadi


using System;
class Program
{
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("adad n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("adad m");
            int m = int.Parse(Console.ReadLine());

            if (n > m)
            {
                Console.WriteLine("please try agian");
                continue;
            }

            Console.WriteLine("please select an option");
            Console.WriteLine("1 - adad zoj");
            Console.WriteLine("2 - adad fard");
            Console.WriteLine("3 - adad avval");
            Console.WriteLine("4 - adad ineei");
            Console.WriteLine("5 - adad kamel");

            int chose = int.Parse(Console.ReadLine());

            Console.WriteLine("adad daray vijegi antekhab shode");

            for (int i = n; i < m; i++)
            {
                bool result = chose switch
                {
                    1 => i % 2 == 0,
                    2 => i % 2 == 1,
                    3 => Isprime(i),
                    4 => Ismirror(i),
                    5 => Isperfect(i),
                    _ => false

                };
                if (result)
                    Console.WriteLine(i);

            }
            Console.WriteLine("darkhast digari darid?");
            string again = Console.ReadLine();
            if (again.ToLower() != "yes")
                break;

        }

    }

    static bool Isprime (int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++) 
        if (num % i == 0) return false;
        return true;

    }

    static bool Ismirror(int num)
    {
        string s = num.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return s == new string(arr);

    }

    static bool Isperfect(int num)
    {
        int sum = 0;
        for (int i = 1; i < num; i++)
        if (num % i == 0)
            sum += i;
        return sum == num;

    }



}