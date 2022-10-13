using System;
namespace FormattedDateTime{
class Program{
    public static void Main(string[] args)
    {
        // GET INPUT FROM USER
        Console.WriteLine("Enter DateTime In the Format  yyyy/MM/dd  hh:mm:ss: msAM or PM \n");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        // print dates and times        
        System.Console.WriteLine($"Complete Date: {inputDate.ToString()}");   // to print complete date in the string
        System.Console.WriteLine($"Short Date: {inputDate.ToShortDateString()}"); // to print short date 
        System.Console.WriteLine($"Long Date: {inputDate.ToLongDateString()}");  // to print long date
        System.Console.WriteLine($"12 Hrs Format: {inputDate.ToString("dd/MM/yyyy hh:mm:ss tt")}");  // to print 12 hrs format
        System.Console.WriteLine($"Date only: {inputDate.ToString("dd/MM/yyyy")}"); // to print date only
        System.Console.WriteLine($"time only: {inputDate.ToString("hh:mm:ss")}"); // to print time only


        
    }
}
}
