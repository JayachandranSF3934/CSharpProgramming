using System;
using System.Collections.Generic;
using AdmissionLibrary;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionApplication
{
    public class Operations
    {
        public static void MainMenu()
    { 
        string willing = " ";
        List<StudentDetails> studentList = new List<StudentDetails>();
       
        // Using Parametized Constructor

            do{
           // Get Student 1 data
          // create object which uses studetdetail template property by using  objectname.property
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
       System.Console.WriteLine("Do you Want To fill Apllication");
       willing = Console.ReadLine().ToLower();
        } while(willing == "yes");

        foreach(StudentDetails details in studentList)
          {
          System.Console.WriteLine("Student Details  Are: \n");
          System.Console.WriteLine($"Register Number: {details.RegisterNumber}");
          System.Console.WriteLine($"Student Name:{details.Name} \n Father Name:{details.FatherName} \n Mother Name:{details.MotherName} \n Date of birth: {details.DOB} \n Gender: {details.Gender} \n Mobile No: {details.MobileNo} \n Mail Id: {details.Mail} \n Chemistry mark: {details.ChemistryMark} \n Physics Mark: {details.PhysicsMark} \n Maths Mark :{details.MathsMark}");
          bool check = details.CheckEligible(80.0);
            if(check)
            {
              System.Console.WriteLine("You Are Eligible");
            }
            else
            {
              Console.WriteLine("You are Not eligible");
            }
          }
    }

        
    }
}