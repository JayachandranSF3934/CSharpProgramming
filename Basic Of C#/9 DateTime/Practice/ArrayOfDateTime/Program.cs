using System;
namespace ArrayOfDateTime {
class Program{
    public static void Main(string[] args)
    {
        // create new datetime array with default values
        DateTime[] dates = { DateTime.Now,new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
        // print all elel=ments in the array
        foreach (var output in dates)
        {
            System.Console.WriteLine("Day:{0:d} Time:{1:g}",output.Date,output.TimeOfDay);   // Day: 8/20/2016 Time: 15:58:26.3566320    
            // d- date  g-timeof day  t-time tt- Am Pm Format  
            System.Console.WriteLine("Day:{0:d} Time: {0:t} {0:tt} \n",output);   //Day: 8/20/2016 Time: 3:58 PM                                   
        }

    }
}
}
