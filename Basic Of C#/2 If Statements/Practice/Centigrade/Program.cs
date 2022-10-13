using System;
namespace Centigrade;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Centigrade: ");
        int centigrade =Convert.ToInt32(Console.ReadLine());

        if (centigrade < 0)
        {
            Console.WriteLine("Freezing Wheather");
        }
        else if(centigrade <=0 && centigrade >10)
        {
             Console.WriteLine("Very Cold Wheather");
        }
        else if(centigrade <= 10 && centigrade > 20)
        {
             Console.WriteLine("Cold Wheather");
        }
        else if(centigrade <= 20 && centigrade > 30)
        {
             Console.WriteLine("Normal in Temperature");
        }
        else if(centigrade <= 30 && centigrade > 40)
        {
             Console.WriteLine("Its Hot");
        }
        else if(centigrade >= 40)
        {
             Console.WriteLine("Its Very hot");
    }
}
