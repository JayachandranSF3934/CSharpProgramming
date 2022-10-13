using System;
namespace Password {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type Your Password Without Mistake:");
        string pass = Console.ReadLine();
        if(pass == "HiTeam")
        {
            Console.WriteLine("Correct Password");
        }
        else
        {
            Console.WriteLine("wrong Password");
        }
    }
}
}