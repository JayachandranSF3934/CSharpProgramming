using System;
namespace ReadWrite;
class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Enter Your Name : ");
    string myName = Console.ReadLine();

    Console.WriteLine("Enter Your Father Name : ");
    string fatherName = Console.ReadLine();

    // Concatination 
    Console.WriteLine("Your name is "+ myName + " and Your Father name is " + fatherName);
    // placeholder
    Console.WriteLine("Your name is {0} and Your Father name is {1} ", myName,fatherName);
    // interploation
    Console.WriteLine($"Your Name is {myName} and your Father name is {fatherName}");

}

}