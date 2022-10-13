using System;
namespace LinearCharacter{
class Program{
    public static void Main(string[] args)
    {
        // initialize Character array
        char[] charArray  = new char[]{'a','j','c','d','g','e','k'};
        // calling LinearsearchCharacter Methods
        LinearSearchCharacter(charArray,'j');

    // linear search  for character Array
        void LinearSearchCharacter(char[] characterarray, char character)
        {
            int count =0;
            for(int i=0;i<characterarray.Length;i++)
            {
                if(characterarray[i] == character)
                {
                    count++;
                    System.Console.WriteLine($"\nThe Character is Found In the Given Character Array at position of  {i}\n");
                } 
            } 
            if(count == 0)
            {
                System.Console.WriteLine("Character Not Found");
            }   
                
        }
    }
}
}
