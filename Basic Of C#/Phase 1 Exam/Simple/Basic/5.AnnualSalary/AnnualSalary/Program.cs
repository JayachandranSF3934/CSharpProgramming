using System;
namespace AnnualSalary{
class Program{
    public static void Main(string[] args)
    {
        int basicsalary = 10000;
        double da = basicsalary *0.1;
        double hra = basicsalary*0.1;

        double salaryannual = 12*(basicsalary+da+hra);
        double tax = salaryannual* 0.05;

        double lpa = salaryannual - tax;

        Console.WriteLine($" The Annual Income of {basicsalary} basicsalary is {lpa} Rupees. ");
        Console.ReadLine();
    }
}
}
