using System;
namespace Anagram {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter NameOne Sting");
        string nameOne = Console.ReadLine();
        Console.WriteLine("Enter NameTwo Sting");
        string nameTwo = Console.ReadLine();


        if(nameOne.Length == nameTwo.Length)
        {
           bool output = nameOne.Contains(nameTwo);
           if(output == true)
           {
            System.Console.WriteLine("NameOne and NameTwo are Anagram");
           }
           else{
            System.Console.WriteLine("NameOne and NameTwo are Not a Anagram");
           }
        }
        else
        {
            System.Console.WriteLine("NameOne and NameTwo Are Not an Anagram");
        }
    }
}
}
