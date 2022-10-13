using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operations
    {  
         //  for creating subMenu new object
        static StudentDetails currentStudent =null;
        static List<StudentDetails> studentList = new List<StudentDetails>();
        public static void MainMenu()

        {  string choice ="yes";
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

         
        public static void  Register()
        {
            System.Console.WriteLine("Enter 1st Student details\n");
           

            System.Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Your  Father Name");
            string fatherName= Console.ReadLine();

            System.Console.WriteLine("Enter Your Mother Name");
            string motherName = Console.ReadLine();

            System.Console.WriteLine("Enter Date of Birth");
            DateTime dob= DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

            System.Console.WriteLine("Enter Gender Male or Female");
            string gender= Console.ReadLine();

            System.Console.WriteLine("Enter Your Mobile Number:");
            long mobileNo = Convert.ToInt64(Console.ReadLine());

            System.Console.WriteLine("Enter your Mail Id");
            string mail= Console.ReadLine();

            System.Console.WriteLine("Enter Your Chemistry Mark:");
            int chemistryMark=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Physics Mark:");
            int physicsMark=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Maths Mark:");
            int mathsMark =Convert.ToInt32(Console.ReadLine());

            
        // To Add Student1 details in list
        StudentDetails student1 =new StudentDetails(name,fatherName,motherName,dob,gender,mobileNo,mail,chemistryMark,physicsMark,mathsMark); 
        studentList.Add(student1); 

       System.Console.WriteLine("You Details Are Collected: \n \n Next Please!! ");
       System.Console.WriteLine("Your Register Number is "+ student1.RegisterNumber);
        } 

        public static void Login()
        {
            System.Console.WriteLine("Enter Your Register Number");
            string regNumber = Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(student.RegisterNumber == regNumber)
                {
                    System.Console.WriteLine("Login Successfully!!!");
                    currentStudent =student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice ="yes";
            do
            {   
                         
            System.Console.WriteLine("Select Options 1.Show Details 2.Check Eligiblity 3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentStudent.ShowDetails();
                    
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Check Eligiblity");
                    bool check = currentStudent.CheckEligible(80.0);
                     if(check)
                        {
                          System.Console.WriteLine("You Are Eligible");
                         }
                     else
                     {
                       Console.WriteLine("You are Not eligible");
                        }

                    break;
                    
                }
                case 3:
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