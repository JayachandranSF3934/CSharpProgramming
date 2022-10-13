using System;
namespace StudentDetails;
class Program {
    public static void Main(string[] args)
    {
        // Get Student Name
        Console.WriteLine("Enter Student Name: ");
        String studentName = Console.ReadLine();
        // Get stuuent father name
         Console.WriteLine("Enter Student Father Name: ");
        String fatherName = Console.ReadLine();
        // Get Age of the student
         Console.WriteLine("Enter Student Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        // Get Gender of Student
        Console.WriteLine("Enter Student Gender: ");
        string gender = Console.ReadLine();
        // Get Email of Student 
         Console.WriteLine("Enter Email Address: ");
        String emailAddress = Console.ReadLine();
        // Get Mobile No of Student
        Console.WriteLine("Enter Student's Mobile Number: ");
        long mobileNo = Convert.ToInt64(Console.ReadLine());
        // Chemistry mark
        Console.WriteLine("Enter Student's Chemistry Marks: ");
        int chemMark = Convert.ToInt32(Console.ReadLine()); 
           // Physics mark
        Console.WriteLine("Enter Student's Physics Marks: ");
        int phyMark = Convert.ToInt32( Console.ReadLine());
           //Mathematics mark
        Console.WriteLine("Enter Student's Mathematics Marks: ");
        int mathMark = Convert.ToInt32( Console.ReadLine());


        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Father Name: " + fatherName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Student Gender: " + gender);
        Console.WriteLine("Email Address: " + emailAddress);
        Console.WriteLine("Student Mobile Number: " + mobileNo);
        Console.WriteLine("Chemistry Mark: " + chemMark);
        Console.WriteLine("Physics Mark: " + phyMark);
        Console.WriteLine("Mathematics Mark: " + mathMark);
        int sum  = chemMark+phyMark+mathMark ;
        double average = (double)(sum)/3.0 ;
        Console.WriteLine("Average :" + average);
        double percent =(double)average/200*100;
        Console.WriteLine("Percentage :"+ percent);

        
        

    }
}