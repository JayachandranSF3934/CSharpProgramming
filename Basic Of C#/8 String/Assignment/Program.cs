using System;
namespace Assignment{
class Program{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter Main String");
        string string1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter String to be searched");
        string string2 = Console.ReadLine().ToLower();
        
        string[] splits = string1.Split(new string[]{string2},StringSplitOptions.None);
        int count =0;
        foreach ( string ans in splits)
        {
            count ++;
        }
        System.Console.WriteLine(count-1);
    }
}
}