using System;
//using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;
    
namespace CollegeAdmission
{
    public static class Operations
    {  
         //  for creating submenu  new object
        static StudentDetails currentStudent =null;
         // To Creating  new object  for admission Details
       // static AdmissionDetails  addmittedStudent = null;
        // To Creating new object for Department Details
       // static DepartmentDetails departmentSelected = null; 
        // To Store student Details in List 
        public static List<StudentDetails> studentList = new List<StudentDetails>();
        // To store Department Details in List
        public static List<DepartmentDetails> departmentList  = new List<DepartmentDetails>();
        //To Store Admission Details in List
        public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

      /* public static void Default()
        { 
        //After Adding student details to list comment this 
        //add default student values to the list studentlist
        StudentDetails student1 = new StudentDetails( "jayachandran", "kamal", new DateTime(1999,10,09),Gender.Male, 89,98,78);
        studentList.Add(student1); 
        StudentDetails student2 = new StudentDetails( "venakt", "kali", new DateTime(1999,10,09),Gender.Male, 89,98,78);
        studentList.Add(student2);

        // add defalt department values to the list
        DepartmentDetails cse = new DepartmentDetails("CSE",30);
        departmentList.Add(cse);
        DepartmentDetails mech = new DepartmentDetails("MECH",30);
        departmentList.Add(mech);
        DepartmentDetails eee = new DepartmentDetails("EEE",30);
        departmentList.Add(eee);
        DepartmentDetails ece = new DepartmentDetails("ECE",30);
        departmentList.Add(ece);

        // add Default Admission details values to the list
        AdmissionDetails student12 = new AdmissionDetails("SF3001","DID101", new DateTime(2022,05,11) ,AdmissionStatus.Booked);
        admissionList.Add(student12);
        AdmissionDetails student13 = new AdmissionDetails("SF3002","DID102",new DateTime(2022,05,11),AdmissionStatus.Booked);
        admissionList.Add(student13);
        }      */ 

  // MainMenu..
        public static void MainMenu()
        { 
            
            //Default();
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("\nSyncfusion College of Engineering and Technology\n\t\tChennai-600028");
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("Welcome To Admission Process");
            System.Console.WriteLine("__________________********_________________________");
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\n\tSelect Options\n1.Student Registeration\n2.Student Login\n3.Check Department Wise Availablity\n4.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Student Registeration");
                    Register();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Student Login");
                    Login();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Check Department Wise Seat Availablity");
                    ShowSeatAvailablity();
                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");  
        }

          // Mainmenu  calling Register 
        public static void  Register()
        {
            System.Console.WriteLine("Enter your details to proceed Further.\n");
           

            System.Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Your  Father Name");
            string fatherName= Console.ReadLine();

            System.Console.WriteLine("Enter Date of Birth");
            DateTime dob= DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

            System.Console.WriteLine("Enter Your Gender: Male , Female, Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Chemistry Mark:");
            int chemistryMark=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Physics Mark:");
            int physicsMark=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Maths Mark:");
            int mathsMark =Convert.ToInt32(Console.ReadLine());

        // To Add Student details in list
        StudentDetails student =new StudentDetails(name,fatherName,dob,gender,chemistryMark,physicsMark,mathsMark); 
        studentList.Add(student); 

       System.Console.WriteLine("\nYou Details Are Collected: \n \n Next Please!! ");
       System.Console.WriteLine("Your Student ID is "+ student.StudentId);
        } 
     // Main Menu Calling Login 
        public static void Login()
        {   
            System.Console.WriteLine("Enter Your Student ID");
            string studId = Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(student.StudentId == studId)
                {
                    System.Console.WriteLine("\nLogin Successfully!!!");
                    currentStudent =student;
                    SubMenu();
                }
            }
        }
         // If Login was sucessful Show SubMenu Otherwise ask Student Id Again.
        public static void SubMenu()
        {  
            System.Console.WriteLine("\nWelcome To Synfusion College Of Engineering\n");
            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\tSelect Options\n1.Check Eligiblity\n2.Show Details\n3.Take Admission\n4.Cancel Admiission\n5.Show Admission Details\n6.Exit");
            int option = int.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Check Eligiblity");
                    bool check = currentStudent.CheckEligible(75.0);
                     if(check)
                        {
                          System.Console.WriteLine("\nYou Are Eligible!!\n");
                         } 
                     else
                     {
                       Console.WriteLine("\nYou are Not eligible\n");
                        }

                    break;
                    
                }
                case 2:
                {
                    System.Console.WriteLine("Show Details\n");
                    currentStudent.ShowDetails();
                    break;
                }
                 case 3:
                {
                    System.Console.WriteLine("Take Admission\n");
                    TakeAdmission();

                    break;
                }
                 case 4:
                {
                    System.Console.WriteLine("Cancel Admission\n");
                    CancelAdmission();
                    break;
                }
                 case 5:
                {
                    System.Console.WriteLine("Show Admission Details\n");
                    ShowAdmissionDetails();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exit SubMenu\n");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes");
        }
      // Take Admission
        public static void TakeAdmission()
        {
            //show department Details
            System.Console.WriteLine("Check Department wise Seats Available Details To Take Admission");
            foreach (DepartmentDetails item in departmentList)
            {
                System.Console.WriteLine($"{item.DepartmentId}   {item.DepartmentName}  {item.NumberOfSeats} ");
            }

            
            // Get department id from user
            System.Console.WriteLine($"Select Department by choosing DepartmentID");
            string getDeptId = Console.ReadLine();
            // Check Seat availablity

            bool test = currentStudent.CheckEligible(75);
            if(test)
            {
                System.Console.WriteLine("You Are Eligible");
            }
            else{
                System.Console.WriteLine("You Are Not Eligible");
            }
            if(test == true)
            {
                System.Console.WriteLine("Your Admission Is Granted");
            }
            AdmissionDetails admission = new AdmissionDetails(currentStudent.StudentId,getDeptId,DateTime.Now,AdmissionStatus.Booked);
            admissionList.Add(admission);

            System.Console.WriteLine($"Your Admission ID is  {admission.AdminssionId}");
            // reduce seat by 1

            foreach (DepartmentDetails item in departmentList)
            {
                if (getDeptId == item.DepartmentId)
                {
                    item.NumberOfSeats --;
                    break;
                }
            }

        }
        public static void CancelAdmission()
        {
            foreach (AdmissionDetails item in admissionList)
            {
                if(item.StudentId == currentStudent.StudentId)
                {
                    if(item.AdmissionStatus == AdmissionStatus.Booked)
                    {
                        item.AdmissionStatus = AdmissionStatus.Cancelled;

                        foreach(DepartmentDetails seat in departmentList)
                        {
                            if(item.DepartmentID == seat.DepartmentId)
                            {
                                seat.NumberOfSeats++;
                                System.Console.WriteLine("Admission Cancelled Succesfully");
                            }
                        }
                    }
                }
            }
        }
        public static void ShowAdmissionDetails()
        {   
            System.Console.WriteLine("Your Admission Details Are:");
            foreach (AdmissionDetails item in admissionList)
            {
                if(currentStudent.StudentId ==item.StudentId)
                {
                   System.Console.WriteLine($"Admmission ID:{item.AdminssionId}\nStudent ID:{item.StudentId}\nDepartment ID:{item.DepartmentID}\nAdmiited Date:{item.AdmissionDate}\nAdmission Status:{item.AdmissionStatus} ");
                }
            }
        }

        public static void ShowSeatAvailablity()
        {
            System.Console.WriteLine("Department Wise Seats Available are listed below for your reference");
            foreach (DepartmentDetails item in departmentList)
            {
                System.Console.WriteLine($"\nDepartmentID: {item.DepartmentId} Department Name: {item.DepartmentName} Seats Available: {item.NumberOfSeats}  ");
            }
    
        }
    }
        

}