using System;
namespace LinearString{
class Program{
    public static void Main(string[] args)
    {
        // initialize StringArray
        string[] stringArray  = new string[]{"Hello Jc","Welcome to linear Search", "thank you"};

        // calling LinearsearchString Methods
        LinearSearchString(stringArray,"Hello Jc");

       // linear search for string  
        void LinearSearchString (string [] array, string content)
        {
            int count =0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i] == content)
                {
                    count++;
                    System.Console.WriteLine($"\nThe String is Found In the Given StringArray at position of  {i}\n");
                }
            } 
            if(count ==0) 
            {
                System.Console.WriteLine("String Not Found"); 
            }      
        }
    }
}
}
