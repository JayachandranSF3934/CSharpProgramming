using System;
namespace CountAlphabets{
class Program{
    public static void Main(string[] args)
    {
    string name;
    int aplhabet =0, digit =0,special =0;
    int i=0;
    int length;
    // Get Input from user
    System.Console.WriteLine("Enter the String: ");
    name =Console.ReadLine().ToLower();
    length = name.Length;
    // count the string characters.
    while(i<length)
    {
        if ((name[i] >= 'a' && name[i]<='z'))
        {
            aplhabet++;
        }
        else if (name[i] >='0' && name[i]<='9')
        {
            digit++;
        }
        else
        {
            special++;
        }
        i++;
    }
    // Print Results of alphabet digit and special characters.
    System.Console.WriteLine("Number of Alphabets in the entered string is :" + aplhabet);
    System.Console.WriteLine("Number of digits in the entered string is :" + digit);
    System.Console.WriteLine("Number of SpecialCharacter in the entered string is :" + special);
    Console.ReadLine();
    }
}
}