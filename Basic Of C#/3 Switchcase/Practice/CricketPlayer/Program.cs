using System;
namespace CricketPlayer{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("India\nPakistan\nBangladesh");
        string menu = Console.ReadLine();

        switch (menu)
        {
            case "India" :
            Console.WriteLine("1.Gambir\n2.Ashwin\n3.Dhoni\n4.Jadeja");
            break;

            case "Pakistan" :
            Console.WriteLine("1.Rizwan\n2.Babar azam\n3.Afridi\n4.Hasan Ali");
            break;

             case "Bangladesh" :
            Console.WriteLine("1.Shahib\n2.Tamim\n3.Rahman\n4.Mortaza");
            break;

            default:
            Console.WriteLine("invalid");
            break;
        }
    }
}
}