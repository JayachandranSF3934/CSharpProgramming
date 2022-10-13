using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLibrary
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

        // MEthod For Calculating Salary

        public int CalculateSalary()
        {
            int salary =0;
            int amount =500;
            salary = (WorkingDays -LeaveTaken)*amount;
            return salary;
        }
    }
}