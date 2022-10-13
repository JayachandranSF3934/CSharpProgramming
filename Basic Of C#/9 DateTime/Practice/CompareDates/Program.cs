using System;
namespace CompareDates {
class Program{
    public static void Main(string[] args)
    {
        // Set  Date and Next Date to compare dates
        DateTime input = new DateTime(2022, 09, 30, 0, 0, 0);
        DateTime nextDate = new DateTime(2022, 09, 30, 12, 0, 0);
        // Using Compare Method Compare Both the Dates,
        int output = DateTime.Compare(input,nextDate);
        // Initialize Print string to store some string value
        string print ;

        // check if output value is less than 0 means eariler, equal to 0 means same, > than 0 means later tahn
        if(output < 0)
        {
            print = "Is Earlier Than";
        }else if(output == 0)
        {
            print = "Is Same As the Time";
        }
        else{
            print = "Is Later Than";
        }
        // print dates
        Console.WriteLine($"{input} {input:tt} {print} {nextDate} {nextDate:tt}");
        Console.ReadLine();
    }
}
}
