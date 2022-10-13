using System;
namespace ExtractASubstring{
class Program{
    public static void Main(string[] args)
    {
        int count =0;
        // get string from user
        Console.WriteLine("Enter The String to Extract A Subsring");
        string input = Console.ReadLine();
        // store string length in lenght usind lenght function
        int length = input.Length;
        // convert string to char array 
        char[] charArray = input.ToCharArray(0,length);

         // Get  position to extract
        System.Console.WriteLine("Enter the position to start extraction:");
        int position = Convert.ToInt32(Console.ReadLine());

        // get length of substring

        System.Console.WriteLine("Enter the length of substring: ");
        int lengthOfSubstring = Convert.ToInt32(Console.ReadLine());

        // to print the substring from starting postion to lengthofSubstring
        System.Console.Write("The substring retrieve from the string is:");
        while(count < lengthOfSubstring)
        {
            System.Console.Write(charArray[position+count -1]);
            count++;
        }
    }
}
}
