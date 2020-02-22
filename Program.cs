namespace Jaroszek.ProofOfCOncept.DayIsOffCalculator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var result = DayOffCalculator.IsDayOff(DateTime.Today);
            Console.WriteLine($"czy dzien pracujący {result}");

            var resultPreviusWorkDay = DayOffCalculator.GetNearestPreviousWorkDay(DateTime.Today);
            Console.WriteLine($"Najbliższy dzień pracujący poprzedzający dzień woly to {resultPreviusWorkDay}");

            var resultNextWorkDay = DayOffCalculator.GetNearestNextWorkDay(DateTime.Today);
            System.Console.WriteLine($"pierwszy następny dzień pracujący to {resultNextWorkDay}");

            Console.ReadKey();
        }
    }
}
