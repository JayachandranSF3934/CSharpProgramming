using System;
namespace ThreeMarkFromUser {
class Program{
    public static void Main(string[] args)
    {
        // get three mark from user
        System.Console.WriteLine("Enter mark1:");
        int markOne = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter mark2:");
        int markTwo = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter mark3:");
        int markThree = Convert.ToInt32(Console.ReadLine());
        // calling method
        CalculateMark(markOne ,markTwo,markThree);

        // creating method

        void CalculateMark(int mark1,int mark2, int mark3)
        {
            
            int average =(mark1+mark2+ mark3);
            double percentage = average*100 /300;
            System.Console.WriteLine("********************");
            System.Console.WriteLine($"Mark1:{mark1}\nMark2:{mark2}\nMark3:{mark3}");
            System.Console.WriteLine("Percentage:"+percentage);
        }
        
    }
}
}
