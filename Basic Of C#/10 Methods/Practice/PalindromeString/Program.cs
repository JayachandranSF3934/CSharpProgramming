using System;
namespace PalindromeString{
class Program{
    public static void Main(string[] args)
    {
        // get input from user
        Console.WriteLine("Enter  String to check Whether It is Palindrome Or Not??");
        string input = Console.ReadLine();
        // calling palindrome methos
        Palindrome(input);

   // Palindrome method
        void Palindrome(string name)
        {
            // convert stirng to char charry
            char[] word = name.ToCharArray();
            // reverse those array using reverse method
            Array.Reverse(word);
            // create new string for comparison
            string wordReverse = new string(word);
            // Use Equal Method to check to string is equal or not
            if(name.Equals(wordReverse))
            {
                System.Console.WriteLine("The String is Palindrome");
            }
            else
            {
                System.Console.WriteLine("The Entered string is Not a Palindrome");
            }

        }
    }
}
}
