using System;
namespace PasswordCheck{
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the password to login:");
        string password = Console.ReadLine();

        if (password == "s3cr3t!P@ssw0rd")
        {
            System.Console.WriteLine(" \nWelcome!!!");
        }
        else 
        {
            System.Console.WriteLine(" \nWrong Password");
        }
    }
}
}
