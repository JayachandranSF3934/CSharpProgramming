using System;
namespace Abstract{
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Syncfusion details");
        Syncfusion employee = new Syncfusion();
        employee.Name = "Jayachandran";
        employee.Salary(15);

        System.Console.WriteLine("Tcs details");
        Tcs employeeOne = new Tcs();
        employeeOne.Name = "venkat";
        employeeOne.Salary(20);
    }
}
}
