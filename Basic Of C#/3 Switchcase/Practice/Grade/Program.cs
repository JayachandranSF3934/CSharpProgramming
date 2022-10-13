using System;
namespace  Grade{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Grade in Uppercase:");
        char grade = Convert.ToChar(Console.ReadLine());
        switch (grade)
        {
            case 'E':
            Console.WriteLine("Excellent");
            break;

            case 'V':
            Console.WriteLine("Very Good");
            break;

            case 'G':
            Console.WriteLine("Good");
            break;

            case 'A':
            Console.WriteLine("Average");
            break;

            case 'F':
            Console.WriteLine("Fail");
            break;
        }
        
    }
}
}