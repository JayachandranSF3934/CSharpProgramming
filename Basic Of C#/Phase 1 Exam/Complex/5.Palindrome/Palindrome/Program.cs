using System;
namespace  Palindrome{
class Program{
    public static void Main(string[] args)
    {

         string string1, reverse;
         Console.WriteLine("Enter String to check whether it is palindrome or not??");
         string1 = Console.ReadLine();
         // Store those string in chararray
         char[] ch = string1.ToCharArray();
         // reverse those string in chararray
          
          for (int i=ch.Length;i>0;i--)
          {
             reverse = string1[i]
          }
         
         reverse = new string(ch);

         if(string1 == reverse)
         {
            System.Console.WriteLine($"The Entered string {string1} is Palindrome ");
         }
         else{
            System.Console.WriteLine($"The Entered String {string1} is Not A Palindrome");
         }
         Console.ReadLine();
    }
}
}
