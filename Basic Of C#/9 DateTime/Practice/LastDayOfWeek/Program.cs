using System;
namespace LastDayOfWeek{
class Program{
    public static void Main(string[] args)
    {
        //get Input From user
        /* 13.		
            Input the Day : 16
            Input the Month : 06
            Input the Year : 2016
            Expected Output :
            The formatted Date is : 16/06/2016
            The last day of the week for the above date is: 18/06/2016
  */

        Console.WriteLine("Enter the Day Of the Month:");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Month Of the Year:");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Year:");
        int year = Convert.ToInt32(Console.ReadLine());
    
        //Create DateTime object 
        DateTime date = new DateTime(year,month,day);

        //formatted date
        System.Console.WriteLine($"The Formatted date is {date.ToString("dd/MM/yyyy")}");

        // last day  of the week
        System.Console.WriteLine($"The last  day of the week is{LastDayOfWeek(date).ToString("dd/MM/yyyy")}");


   
        
    }
     public static DateTime LastDayOfWeek (DateTime date)
        {
            //Gets or sets the CultureInfo object that represents the culture used by the current thread and task-based asynchronous operations.
            /* The current culture is a property of the executing thread. When you set this property to a CultureInfo object that represents a new culture, the value of the Thread.CurrentThread.CurrentCulture property also changes. However, we recommend that you always use the CultureInfo.CurrentCulture property to retrieve and set the current culture. */
            var cul = System.Threading.Thread.CurrentThread.CurrentCulture;
            //Gets the day of the week represented by this instance.  dayOfWeek Property
            var remainingDay =date.DayOfWeek - cul.DateTimeFormat.FirstDayOfWeek;
            
            if(remainingDay <0)
            {
                remainingDay += 7;
                          
            }
            //if we gat the first day  of week  we can find its last day week 
            return date.AddDays(remainingDay).Date;
        }
}
}
