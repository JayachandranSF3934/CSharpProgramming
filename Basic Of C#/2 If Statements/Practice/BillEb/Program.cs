using System;
namespace BillEb{
class Program{
    public static void Main(string[] args)
    {   
       
        Console.WriteLine("Enter Customer Id");
        int id =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Customer Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Uint Consumed");
        int unit = Convert.ToInt32(Console.ReadLine());
        double charge = 0;
// Output
        Console.WriteLine($"Customer IDNO :{id}");
        Console.WriteLine($"Customer Name :{name}");
        Console.WriteLine($"Unit Consumed {unit}");

       
        if(unit >0 && unit <=199)
        {
            charge = unit*1.20;
            Console.WriteLine($"Net Amount Paid By the Customer : {charge}");
        }
        else if (unit >= 200 && unit <400)
        {
            charge = unit*1.50;
            Console.WriteLine($"Net Amount Paid By the Customer : {charge}");
        }
        else if (unit >=400 && unit < 600)
        {
            charge = unit*1.80;
            Console.WriteLine($"Net Amount Paid By the Customer : {charge}");
        }
        else if (unit >600 )
        {
           charge = unit*2.00;
            Console.WriteLine($"Net Amount Paid By the Customer : {charge}");
        }
        if(charge>=400)
        {
            double Surcharge =0;
            Surcharge =  charge *0.15;
            System.Console.WriteLine($"Surcharge amount is {Surcharge}");
        }

        

    }
}
}