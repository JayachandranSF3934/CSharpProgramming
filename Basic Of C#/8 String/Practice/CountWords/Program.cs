using System;
namespace CountWords{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string :");
        string string1 = Console.ReadLine().ToLower();
        string string2 = " ";
        
        string[] splits = string1.Split(new string[]{string2},StringSplitOptions.None);
        int count =0;
        foreach ( string ans in splits)
        {
            count ++;
        }
        System.Console.WriteLine(count);
    }
}
}
