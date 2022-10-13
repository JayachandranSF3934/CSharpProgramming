using System;
namespace CompareCurrentDateWithFuture{
class Program{
    private enum DateOutput{
        Earlier =-1 ,Later = 1, Same =0};
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        DateTime nextYear ,lastYear;

        nextYear = date.AddYears(1);
        lastYear = date.AddYears(-1);

        DateOutput comparison;
        comparison =  (DateOutput) date.CompareTo(lastYear);
        System.Console.WriteLine($"{(int) comparison} {date:d} is {comparison.ToString().ToLower()} than {lastYear:d} ");
        System.Console.WriteLine($"{(int) comparison} {date:d} is {comparison.ToString().ToLower()} than {nextYear:d} ");
                Console.WriteLine();
        Console.ReadLine();
    }
}
}
