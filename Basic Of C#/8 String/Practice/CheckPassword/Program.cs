using System;
namespace CheckPassword {
class Program{
    public static void Main(string[] args)
    {
       // using do while loop to check Entered password is Correct or Not
       string name;
       string password;
       int count =0;
       do
       {
            System.Console.WriteLine("Enter Your Username");
            name =Console.ReadLine();
            System.Console.WriteLine("Enter Your Password");
            password =(Console.ReadLine());
            
            if(name != "abcd" || password != "abcd")
            {
                count++;
            }
            else
            {
                count=1;
            }
            Console.ReadLine();      
       }while((name != "user" || password != "pass") && (count !=3));
       if(count == 3)
      {
       System.Console.WriteLine("Try after some time");
      }
      else
       {
        System.Console.WriteLine("login Succesfully ");
        Console.ReadLine();
       }

       
    }
}
}
