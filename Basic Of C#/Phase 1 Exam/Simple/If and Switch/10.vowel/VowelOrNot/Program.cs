using System;
namespace VowelOrNot{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Character to find whether it is vowel or not");
        char alphabet = Convert.ToChar(Console.ReadLine().ToLower());

        if(alphabet == 'a' || alphabet == 'e' ||alphabet == 'i' || alphabet == 'o' || alphabet == 'u'  )
        {
            System.Console.WriteLine("The Entered Character is VOWEL!");
        }else
        {
            System.Console.WriteLine("The Entered Character is NOT  A VOWEL !!");
        }
    }
}
}
