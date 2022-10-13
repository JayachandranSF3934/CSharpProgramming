using System;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CollegeAdmission
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating College Folder");
                Directory.CreateDirectory("College");        // creating College Folder for Student
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Student File Created");
                File.Create("College/StudentDetails.csv");      // creating Files for Student details
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Admission File Created");  // creating Files for Admission Details
                File.Create("College/AdmissionDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Department File Created");  // Creating Files for Department Details
                File.Create("College/DepartmentDetails.csv");
            }
        }

        // to read all files in list
        public static void ReadFile()
        {
            // Student Details Read
            string[] students = File.ReadAllLines("College/StudentDetails.csv");
            foreach (var data in students)
            {
                StudentDetails student = new StudentDetails(data);
                Operations.studentList.Add(student);
            }

             // admission Read
            string[] admissions = File.ReadAllLines("College/AdmissionDetails.csv");
            foreach (var item in admissions)
            {
                AdmissionDetails admission = new AdmissionDetails(item);
                Operations.admissionList.Add(admission);
            }
            // department read

            string [] departments = File.ReadAllLines("College/DepartmentDetails.csv");
            foreach (var dept in departments)
            {
                DepartmentDetails department = new DepartmentDetails(dept);
                Operations.departmentList.Add(department);
            }
        }
        // to write in files in list
        public static void WriteToFiles()
        {
            string[] studentDetails = new string[Operations.studentList.Count];

            for (int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i] = Operations.studentList[i].StudentId+","+ Operations.studentList[i].Name+","+ Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+ Operations.studentList[i].Gender+","+ Operations.studentList[i].ChemistryMark+","+ Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].MathsMark ;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);

           // write files for admission list
            string [] admissionDetails= new string[Operations.admissionList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i] = Operations.admissionList[i].AdminssionId+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus+","+Operations.admissionList[i].DepartmentID+","+Operations.admissionList[i].StudentId ;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);

            // write files for Department list
            string[] departmantDetails = new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.departmentList.Count;i++)
            {
                departmantDetails[i] = Operations.departmentList[i].DepartmentId+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats ;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmantDetails);
             }

        // update method 

        public static void Update()
        {
            System.Console.WriteLine("-------------------------------------------------------------------------");
            System.Console.WriteLine("Wlecome to Updation Page \n\t In this Page You can Change your Name and YourFather Name \n\nTO Proceed Select Choices Listed Below:");
            System.Console.WriteLine("Select Choice 1.Your Name 2.Father Name");
            int option = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Name to be Updated");
            string name = Console.ReadLine();
            
            string[] lines = File.ReadAllLines("College/StudentDetails.csv");

            for(int i=0;i<lines.Length;i++)
            {
                if(lines[i] !="")
                {
                    var values = lines[i].Split(',');
                    if(values[option] == name)
                    {
                        System.Console.WriteLine("Enter Name");
                        string name1 =Console.ReadLine();
                        if(option == 0)
                        {
                            lines[i] = name1+","+values[1]+","+values[2]+","+values[3]+","+values[4]+","+values[5]+","+values[6]+","+values[7];
                        }
                        else if(option ==1)
                        {
                            lines[i] = values[0]+","+name1 +","+ values[2]+","+values[3]+","+values[4]+","+values[5]+","+values[6]+","+values[7];
                        }
                    }
                }
            }
            File.AppendAllLines("College/StudentDetails.csv",lines);
        }
    }


   
}