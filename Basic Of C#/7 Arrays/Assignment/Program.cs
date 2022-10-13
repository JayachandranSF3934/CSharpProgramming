using System;
namespace Assignment {
class Program{
    public static void Main(string[] args)
    {   // Get size
      int size1 = 0; 
        Console.WriteLine("Enter Size Of The Array: ");
        size1 = Convert.ToInt32(Console.ReadLine());

        //get names
       string[] names = new string[size1];
        for(int i=0;i<size1;i++)
        {
            System.Console.WriteLine("Enter Name:");
            names[i] = Console.ReadLine().ToLower();
        }

        // Show Names
        System.Console.WriteLine("Names in the array");
        for(int j=0;j<names.Length;j++)
        {   
            System.Console.WriteLine(""+names[j]);
        }

        // Get a name from the user
        System.Console.WriteLine("Enter The Name to search in the array");
        string getName = Console.ReadLine().ToLower();

        // search name in the array using for loop
         int count =0;
        for(int k=0;k<names.Length;k++)
        {
            if(getName == names[k])
            {
                System.Console.WriteLine("The name is present in array ");
                System.Console.WriteLine($"Index value is :{k}");
                count++;
            }  
        } 
        if (count ==0)
        {
            System.Console.WriteLine("The name is  Not present in the  array");
        }
          
        // Get input from the user
        
        System.Console.WriteLine("Enter The Name to search in the array");
        string getName2 = Console.ReadLine().ToLower();
        
        int count2 =0;
        foreach(string val in names){
            if (getName2 == val )
            {
                System.Console.WriteLine(" The name is present in the array For Each  ");
                count2 ++;
            }
        }if (count2 == 0)  
        {
            System.Console.WriteLine("The name is  Not present in the array");
        } 
}
} 
}

 