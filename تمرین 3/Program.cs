// tamrin 3
// Amirhossein Mohammadi

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool[] answers = new bool[5];

        Console.WriteLine("1- ayay shoma mostaghel hastid? (true/false)");
        answers[0] = bool.Parse(Console.ReadLine());

        Console.WriteLine("2- ayay shoma mojarrad hastid? (true/false)");
        answers[1] = bool.Parse(Console.ReadLine());

        Console.WriteLine("3- ayay shoma shaghel hastid? (true/false)");
        answers[2] = bool.Parse(Console.ReadLine());

        Console.WriteLine("4- ayay shoma khane darid? (true/false)");
        answers[3] = bool.Parse(Console.ReadLine());

        Console.WriteLine("5- ayay shoma mashin darid? (true/false)");
        answers[4] = bool.Parse(Console.ReadLine());

        string result = GetDecisionResult(answers);
        string welfare = GetWelfareLevel(answers);

        Console.WriteLine("\n🔍 نتیجه: " + result);
        Console.WriteLine("📊 سطح رفاه شما: " + welfare);
    }

    static string GetDecisionResult(bool[] a) => a switch
    {
        [true, true, true, true, true] => "مستقل، مجرد، شاغل، خانه‌دار، ماشین‌دار",
        [true, true, true, true, false] => "مستقل، مجرد، شاغل، خانه‌دار، بدون ماشین",
        [true, true, true, false, true] => "مستقل، مجرد، شاغل، بدون خانه، ماشین‌دار",
        [true, true, true, false, false] => "مستقل، مجرد، شاغل، بدون خانه، بدون ماشین",
        [true, true, false, true, true] => "مستقل، مجرد، بیکار، خانه‌دار، ماشین‌دار",
        [true, true, false, true, false] => "مستقل، مجرد، بیکار، خانه‌دار، بدون ماشین",
        [true, true, false, false, true] => "مستقل، مجرد، بیکار، بدون خانه، ماشین‌دار",
        [true, true, false, false, false] => "مستقل، مجرد، بیکار، بدون خانه، بدون ماشین",
        [true, false, true, true, true] => "مستقل، متأهل، شاغل، خانه‌دار، ماشین‌دار",
        [true, false, true, true, false] => "مستقل، متأهل، شاغل، خانه‌دار، بدون ماشین",
        [true, false, true, false, true] => "مستقل، متأهل، شاغل، بدون خانه، ماشین‌دار",
        [true, false, true, false, false] => "مستقل، متأهل، شاغل، بدون خانه، بدون ماشین",
        [true, false, false, true, true] => "مستقل، متأهل، بیکار، خانه‌دار، ماشین‌دار",
        [true, false, false, true, false] => "مستقل، متأهل، بیکار، خانه‌دار، بدون ماشین",
        [true, false, false, false, true] => "مستقل، متأهل، بیکار، بدون خانه، ماشین‌دار",
        [true, false, false, false, false] => "مستقل، متأهل، بیکار، بدون خانه، بدون ماشین",
        [false, true, true, true, true] => "وابسته، مجرد، شاغل، خانه‌دار، ماشین‌دار",
        [false, true, true, true, false] => "وابسته، مجرد، شاغل، خانه‌دار، بدون ماشین",
        [false, true, true, false, true] => "وابسته، مجرد، شاغل، بدون خانه، ماشین‌دار",
        [false, true, true, false, false] => "وابسته، مجرد، شاغل، بدون خانه، بدون ماشین",
        [false, true, false, true, true] => "وابسته، مجرد، بیکار، خانه‌دار، ماشین‌دار",
        [false, true, false, true, false] => "وابسته، مجرد، بیکار، خانه‌دار، بدون ماشین",
        [false, true, false, false, true] => "وابسته، مجرد، بیکار، بدون خانه، ماشین‌دار",
        [false, true, false, false, false] => "وابسته، مجرد، بیکار، بدون خانه، بدون ماشین",
        [false, false, true, true, true] => "وابسته، متأهل، شاغل، خانه‌دار، ماشین‌دار",
        [false, false, true, true, false] => "وابسته، متأهل، شاغل، خانه‌دار، بدون ماشین",
        [false, false, true, false, true] => "وابسته، متأهل، شاغل، بدون خانه، ماشین‌دار",
        [false, false, true, false, false] => "وابسته، متأهل، شاغل، بدون خانه، بدون ماشین",
        [false, false, false, true, true] => "وابسته، متأهل، بیکار، خانه‌دار، ماشین‌دار",
        [false, false, false, true, false] => "وابسته، متأهل، بیکار، خانه‌دار، بدون ماشین",
        [false, false, false, false, true] => "وابسته، متأهل، بیکار، بدون خانه، ماشین‌دار",
        [false, false, false, false, false] => "وابسته، متأهل، بیکار، بدون خانه، بدون ماشین",
        _ => "pasokh ha na motabarand"
    };

    static string GetWelfareLevel(bool[] answers)
    {
        int trueCount = answers.Count(x => x);
        return trueCount switch
        {
            1 or 5 => "aali",
            2 => "khob",
            3 => "motevaset",
            4 => "zaeif",
            0 => "besiiar zaeif",
            _ => "namoshakhas"
        };
    }
}
