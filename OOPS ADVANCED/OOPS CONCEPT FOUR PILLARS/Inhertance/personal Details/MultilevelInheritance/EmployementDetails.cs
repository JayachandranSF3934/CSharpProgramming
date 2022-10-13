using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class EmployementDetails:StudentDetails  // inherit StudentDetails to Employee Details
    {
        private static int s_employementId = 234100;

        public string EmployementId { get; set; }
        public DateTime RegisterationDate { get; set; }

      // construcor
        public EmployementDetails(string studentId,string aid,string name,string fatherName,Gender gender,long mobileNumber,Department department):base( studentId,aid,name,fatherName,gender,mobileNumber,department)
        {
            s_employementId++;
            EmployementId ="EID"+s_employementId;
            RegisterationDate = DateTime.Now;
        }

        public void ShowEmployementDetails()
        {
            System.Console.WriteLine("--------------------------------------------------------------------");
            System.Console.WriteLine("EMPLOYEEMENT PROCESS");
            System.Console.WriteLine($"EmployementId: {EmployementId}");
            ShowStudentDetails();
            System.Console.WriteLine($"Registeration date: {RegisterationDate.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}