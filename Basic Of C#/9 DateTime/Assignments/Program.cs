using System;
namespace Assignments{
class Program{
    public static void Main(string[] args)
    {
        // create new date object
        DateTime  dtshow = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(dtshow);

        //Convert DateTime to string
         DateTime  dtstring = new DateTime(2021,8,10,10,40,32);
         string dtstr = dtstring.ToString("tt ss:mm:HH dd/MM/yyyy");
         System.Console.WriteLine(dtstr);

         // string to year month day
         string datestring = ("2011/09/08 8:07:45 Am");
         DateTime dt = Convert.ToDateTime(datestring);
         System.Console.WriteLine($"Year:{dt.Year} \nMonth:{dt.Month} \nDay:{dt.Day}");  
    }
}
}