using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public static class Operation
    {
        // Creating New object for submenu
        static PayrollDetails currentEmployee = null;
        // Creating new List for PayrollDetails
       static  List<PayrollDetails> employeeList =new List<PayrollDetails>();

       // creating static mainmenu
       public static void MainMenu()
       {
        string choice ="yes";
            do
            {            
            System.Console.WriteLine("Select Options 1.Register 2.Login 3.Exit");
            int option = int.Parse(Console.ReadLine());
    
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Register");
                    Register();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");  
       }
       public static void Register()
       {
          string input = " ";
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

           
            System.Console.WriteLine("Do You Want To Generate Next Employee Payroll?? yes or no");
            input = Console.ReadLine().ToLower();
        }while(input == "yes");
       }

       public static void Login()
        {
            System.Console.WriteLine("Enter Your Register Number");
            string IdNumber = Console.ReadLine().ToUpper();
            foreach(PayrollDetails employee in employeeList)
            {
                if(employee.EmployeeId== IdNumber)
                {
                    System.Console.WriteLine("Login Successfully!!!  \n You can generate your payroll by using Calculate salary!!!");
                    currentEmployee =employee;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("Select Options 1.Show Details 2.Get Number of Leaves taken in a month 3.Calculate Salary 4.Exit SubMenu");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentEmployee.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Get Number of leaves Taken");
                    currentEmployee.GetNumberOfLeave();
                    break;  
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate Salary");
                    currentEmployee.CalculateSalary();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit SubMenu");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");
        }

    }
}