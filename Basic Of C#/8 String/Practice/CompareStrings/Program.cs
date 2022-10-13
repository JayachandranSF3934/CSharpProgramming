using System;
namespace CompareStrings{
class Program{
    public static void Main(string[] args)
    {
        //Get input Strings
        System.Console.WriteLine("Enter First String: ");
        string string1 = Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter Second String: ");
        string string2 =Console.ReadLine().ToLower();
        int count =0;
        //Compare string elements using  index value
        for(int i=0;i<string1.Length;i++)
        {
            if(string1[i] == string2[i])
            {
                count++;
            }   
        }
        // if length is same and  string values are same then print equal otherwise print not equal.
        if(count == string1.Length)
        {
            System.Console.WriteLine("Entered both the strings are Equal");
        }
        else
            {
                System.Console.WriteLine("Entered Both Strings are Not Equal they are Different");
            } 
    }
}
}
