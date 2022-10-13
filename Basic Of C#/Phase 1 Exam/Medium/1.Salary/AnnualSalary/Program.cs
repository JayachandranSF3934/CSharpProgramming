using System;
namespace AnnualSalary {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input Basic salary of an employee");
        int basic = Convert.ToInt32(Console.ReadLine());
        double grosssalary =0;
        double takehomesalary =0;
        double hra,da;
        double tax,insurance;

        if(basic <= 10000)
        {
            hra = basic*0.2;
            da = basic*0.8;
            grosssalary = 12*basic+hra+da;
            tax =grosssalary*0.06;
            insurance = grosssalary*0.01;
            takehomesalary = grosssalary -(tax+insurance);

            System.Console.WriteLine("The GrossSalary Per Year:"+grosssalary);
            System.Console.WriteLine("The TakeHomeSalary Per Year: "+takehomesalary);
        }
        else if(basic >10000 && basic<=20000)
        {
            hra = basic*0.25;
            da = basic*0.9;
            grosssalary = 12*basic+hra+da;
            tax =grosssalary*0.06;
            insurance = grosssalary*0.01;
            takehomesalary = grosssalary -(tax+insurance);

            System.Console.WriteLine("The GrossSalary Per Year:"+grosssalary);
            System.Console.WriteLine("The TakeHomeSalary Per Year: "+takehomesalary);
        }
        else if(basic < 20000)
        {
            hra = basic*0.3;
            da = basic*0.95;
            grosssalary = 12*basic+hra+da;
            tax =grosssalary*0.06;
            insurance = grosssalary*0.01;
            takehomesalary = grosssalary -(tax+insurance);

            System.Console.WriteLine("The GrossSalary Per Year:"+ grosssalary);
            System.Console.WriteLine("The TakeHomeSalary Per Year: "+ takehomesalary);
        }
    }
}
}
