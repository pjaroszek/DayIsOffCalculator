namespace Jaroszek.ProofOfCOncept.DayIsOffCalculator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
var dateToCheck = DateTime.Parse("2020-01-06");//DateTime.Today);

            var result = DayOffCalculator.IsDayOff(dateToCheck);
            Console.WriteLine($"czy {dateToCheck} jest dniem wolnym od pracy? -> {result}");

            var resultPreviusWorkDay = DayOffCalculator.GetNearestPreviousWorkDay(dateToCheck);
            Console.WriteLine($"Najbliższy dzień pracujący poprzedzający dzień woly to {resultPreviusWorkDay}");

            var resultNextWorkDay = DayOffCalculator.GetNearestNextWorkDay(dateToCheck);
            System.Console.WriteLine($"pierwszy następny dzień pracujący to {resultNextWorkDay}");

            Console.ReadKey();
        }
    }
}
