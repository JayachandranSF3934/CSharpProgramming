using System;
namespace LengthOfString{
class Program{
    public static void Main(string[] args)
    {
        string input = " ";
        int count =0;
        // get input from user
        Console.WriteLine("Input the String: ");
        input = Console.ReadLine();
        // count characters
        foreach( char words in input)
        {
            count = count+1;
        }
        //print length
        System.Console.WriteLine($"Length of the string is {count}");
        Console.ReadLine();
    }
}
}