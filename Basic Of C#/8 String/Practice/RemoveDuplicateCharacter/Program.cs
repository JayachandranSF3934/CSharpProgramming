using System;
namespace  RemoveDuplicateCharacter{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter String To Remove Duplicate Characters");  // duplicate means it does not repeat agian inthe string
        string input =Console.ReadLine();
        // intilaize empty string
        string removeChar = string.Empty;

        // find repeated same char in the string to remove
        for(int i=0; i<input.Length ;i++)
        {
            // if char in removechar contains any char of input  add it to remove char
            if(!removeChar.Contains(input[i]))
            {
                removeChar += input[i];
            }
        }
        System.Console.WriteLine(removeChar);
       
    }
}
}
