using System;
namespace Reverse{
class Program{
    public static void Main(string[] args)
    {
        string words = " ";
        int size =0;
        //Get the string
        Console.WriteLine("Enter the String");
        words = Console.ReadLine();
        //print characters.
        System.Console.WriteLine("The Characters of the Given String in Reverse Order:");
        size =words.Length -1;
        while(size>=0)
        {
            System.Console.Write($"{words[size]} ");
            size--;
        }
    }
}
}