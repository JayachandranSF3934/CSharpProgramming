using System;
using System.Collections.Generic;
namespace EmployeePayroll {
class Program{
    public static void Main(string[] args)
    {
        string input =" ";
        // Creating new List for PayrollDetails
        List<PayrollDetails> employeeList =new List<PayrollDetails>();
        //Getting Details
        do
        {
            System.Console.WriteLine("Enter Employee Details to Generate Payroll\n");

            // Get Employee Details
            System.Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Employee Role:");
            string role =Console.ReadLine();

            System.Console.WriteLine("Enter Your Gender  Male , Female, Transgender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            
            System.Console.WriteLine("Enter Employee WorkLocation: Mathura, Eymard");
            WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            
            System.Console.WriteLine("EnterEmployee Team Name:");
            string  teamName = Console.ReadLine();
            
            System.Console.WriteLine("Enter  Employee Date of Joining");
            DateTime doj= DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

            System.Console.WriteLine("Enter Number of Working Days in the Month:");
            int workingDays = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Number Of Leaving Taken in a month");
            int leaveTaken = Convert.ToInt32(Console.ReadLine());

            // TO Add Employee Details in List  employeeList
            PayrollDetails employee = new PayrollDetails(name,role,workLocation,teamName,doj,workingDays,leaveTaken,gender);
            employeeList.Add(employee);
            System.Console.WriteLine("You Details Are Collected: \n \n Next Please!! ");
            System.Console.WriteLine("Your Register Number is "+ employee.EmployeeId);

            // Details are collected
           
            System.Console.WriteLine("Do You Want To Generate Next Employee Payroll??");
            input = Console.ReadLine().ToLower();
        }while(input == "yes");

        foreach(PayrollDetails values in employeeList)
        {
            System.Console.WriteLine("Employee Details Are:\n");
            System.Console.WriteLine($"Employee ID:{values.EmployeeId}");
            System.Console.WriteLine($"Employee Name: {values.Name}\nEmployee Role: {values.Role}\nWork Location: {values.WorkLocation}\nTeam Name: {values.TeamName}\nEmployee Date Of Joining: {values.Doj.ToShortDateString}\nNumber of working days in month: {values.WorkingDays}\nNumber of leave taken: {values.LeaveTaken}\nGender: {values.Gender}");
            int totalSalary  = values.CalculateSalary();
            System.Console.WriteLine($"TotalSalary: {totalSalary}");
            
        }  
    }
}
}
