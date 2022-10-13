using System;
namespace MonthWiseSalary {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name of Month ");
        string month = Console.ReadLine().ToLower();
        System.Console.WriteLine($"Enter Leaves taken in {month} month");
        int leave = Convert.ToInt32(Console.ReadLine());
        int amount = 500;
        int salary =0;
        // salary calculation

        if(month == "january" || month == "march" || month == "may" || month == "july" || month == "augest" || month == "october" || month == "december" )
        {
            salary = (23-leave)*amount;
            System.Console.WriteLine("Total Salary is" +salary);
        }
        else if(month == "april" || month == "june" || month == "september" || month == "november"  )
        {
            salary = (22-leave)*amount;
            System.Console.WriteLine("Total Salary is" + salary);
        }
        else if(month == "feburary")
        {
            salary = (20-leave)*amount;
            System.Console.WriteLine(salary);
        }
        else {
            System.Console.WriteLine("Invalid Month ");
        }
    }
}
}
