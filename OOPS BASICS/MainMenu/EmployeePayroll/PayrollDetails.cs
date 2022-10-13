using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    // Enum for Gender
    public enum  Gender{Default ,Male,Female,Transgender}
    // Enum for Work Location
    public enum  WorkLocation{Default , Mathura,Eymard}
    public class PayrollDetails
    {
        //
        private static int s_employeeId = 1000;
        // Property
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime Doj { get; set; }
        public int WorkingDays { get; set; }
        public int LeaveTaken { get; set; }
        public Gender Gender { get; set; }

        //Parameterised Constructor
        public PayrollDetails(string name, string role, WorkLocation workLocation, string teamName,DateTime doj,int workingDays,int leaveTakenm, Gender gender)
        {
            s_employeeId++;
            EmployeeId = "SF" +s_employeeId;
            Name = name;
            Role = role;
            WorkLocation = workLocation;
            TeamName =teamName;
            Doj = doj;
            WorkingDays =workingDays;
            LeaveTaken = leaveTakenm;
            Gender =gender;
        }


        // Method for showing details
        public void ShowDetails()
        {
          System.Console.WriteLine("Employee Details Are:\n");
            System.Console.WriteLine($"Employee ID:{EmployeeId}");
            System.Console.WriteLine($"Employee Name: {Name}\nEmployee Role: {Role}\nWork Location: {WorkLocation}\nTeam Name: {TeamName}\nEmployee Date Of Joining: {Doj.ToShortDateString}\nNumber of working days in month: {WorkingDays}\nNumber of leave taken: {LeaveTaken}\nGender: {Gender}\n");  
        }
        // MEthod For Calculating Salary


        public void GetNumberOfLeave()
        {
            int show = LeaveTaken;
            System.Console.WriteLine("Number of Leave taken in a month : "+show);
        }
        public int CalculateSalary()
        {
            int salary =0;
            int amount =500;
            salary = (WorkingDays -LeaveTaken)*amount;
            System.Console.WriteLine($"TotalSalary: {salary}");
            return salary;
        }
    }
}