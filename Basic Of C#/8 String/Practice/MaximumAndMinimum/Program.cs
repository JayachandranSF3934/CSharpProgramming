using System;
using System.Linq;
namespace MaximumAndMinimum{
class Program{
    public static void Main(string[] args)
    {
    
        // string of numbers
        string num = "3 4 8 9 0 2 1";
        var  data = num.Split(' ');
        int[] array = new int[data.Length];

        int j=0;
        foreach(string i in data)
        {
            array[j] = int.Parse(i);
            j++;
        }
        foreach (int item in array)
        {
            System.Console.Write(item+" ");
        }

        int max = array.Max();
        int min = array.Min();
       System.Console.WriteLine($"\nMaximum: {max}");
       System.Console.WriteLine($"Maximum: {min}");



      
       
      
    }

    
}
}
