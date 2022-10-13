using System;
namespace SubstringPresentInString{
class Program{
    public static void Main(string[] args)
    {
        // Get string and substring to be compared
        System.Console.WriteLine("Enter the string:");
        string string1 =Console.ReadLine();
        System.Console.WriteLine("Enter Substring to be searched:");
        string substring = Console.ReadLine();
        // search using  inbuilt contain() method
        if(string1.Contains(substring))
        {
            System.Console.WriteLine("The Substring is Exist in the above string");
        }
        else
        {
            System.Console.WriteLine("The Substring is Not Exist in the above string");
        }
    }
}
}
