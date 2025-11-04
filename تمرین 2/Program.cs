// tamrin 2
// Amirhossein Mohammadi

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("adad m");
            int m = int.Parse(Console.ReadLine());

            Console.Write("adad n");
            int n = int.Parse(Console.ReadLine());

            if (n > m)
            {
                Console.WriteLine("خطا: عدد n باید کوچکتر یا مساوی m باشد. لطفاً دوباره تلاش کنید.");
                continue;
            }

            Console.WriteLine("adad avval");
            for (int i = n; i <= m; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.Write(i + " ");
            }

            Console.WriteLine("goldbakh");
            for (int i = n; i <= m; i++)
            {
                if (i > 2 && i % 2 == 0)
                {
                    for (int a = 2; a < i; a++)
                    {
                        bool aPrime = true;
                        for (int j = 2; j <= Math.Sqrt(a); j++)
                            if (a % j == 0) { aPrime = false; break; }

                        int b = i - a;
                        bool bPrime = true;
                        for (int j = 2; j <= Math.Sqrt(b); j++)
                            if (b % j == 0) { bPrime = false; break; }

                        if (aPrime && bPrime)
                        {
                            Console.WriteLine(i + " = " + a + " + " + b);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("lemoin");
            for (int i = n; i <= m; i++)
            {
                if (i > 5 && i % 2 != 0)
                {
                    for (int p = 2; p < i; p++)
                    {
                        bool pPrime = true;
                        for (int j = 2; j <= Math.Sqrt(p); j++)
                            if (p % j == 0) { pPrime = false; break; }

                        if (!pPrime) continue;

                        int q = (i - p) / 2;
                        bool qPrime = true;
                        for (int j = 2; j <= Math.Sqrt(q); j++)
                            if (q % j == 0) { qPrime = false; break; }

                        if (p + 2 * q == i && qPrime)
                        {
                            Console.WriteLine(i + " = " + p + " + 2×" + q);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("darkhast digari darid? (y/n)");
            string again = Console.ReadLine();
            if (again.ToLower() != "y")
                break;
        }
    }
}