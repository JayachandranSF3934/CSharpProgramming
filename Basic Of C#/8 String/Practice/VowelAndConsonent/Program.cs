using System;
namespace VowelAndConsonent{
class Program{
    public static void Main(string[] args)
    {
        int i,size,vowel =0,consonent=0;
        Console.WriteLine("Enter the String");
        string string1 = Console.ReadLine().ToLower();
        size = string1.Length;
        for(i=0;i<size;i++)
        {
            if(string1[i] == 'a' || string1[i] =='e'|| string1[i] =='i'|| string1[i] =='o'|| string1[i] =='u')
            {
                vowel++;
            }
            else if(string1[i] >= 'a' && string1[i]<='z')
            {
                consonent++;
            }
        }
        System.Console.WriteLine($"The Total Number Of Vowels in the Given String is:{vowel}"); 
        System.Console.WriteLine($"The Total Number Of Consonents in the Given String is:{consonent}");         
        
    }
}
}
