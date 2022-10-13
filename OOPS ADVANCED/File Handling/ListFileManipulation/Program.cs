using System;
using System.Collections.Generic;
using System.IO;

namespace ListFileManipulation{
class Program{
public static void Main(string[] args)
{
    List<StudentDetails> stuList = new List<StudentDetails>();

    stuList.Add(new StudentDetails(){Name ="Jaya",FatherName = "Kamal" ,Gender= Gender.Male,DOB =new DateTime(2002,12,02) });
    stuList.Add(new StudentDetails(){Name ="Jaya",FatherName = "Kamal" ,Gender= Gender.Male,DOB =new DateTime(2002,12,02) });
    stuList.Add(new StudentDetails(){Name ="Jaya",FatherName = "Kamal" ,Gender= Gender.Male,DOB =new DateTime(2002,12,02) }); 

    // calling insert Method

    Insert(stuList);   // insert 
    Display();   // display Entered data

}
static void Insert(List<StudentDetails> stuList)
{
  StreamWriter write = null;
  if(!File.Exists("Data.csv"))
  {
    System.Console.WriteLine("File Doesn't Exist , Creating CSV File");
    File.Create("Data.csv");
  }  
  else{
    System.Console.WriteLine("\nFile Founded!!");
  }

  write = new StreamWriter(File.OpenWrite("Data.csv"));
  foreach (var item in stuList)
  {
    write.WriteLine(item.Name+","+item.FatherName+","+item.Gender+","+item.DOB.ToString("dd/MM/yyyy"));    //  +","+ is used to write in cells in the excel data
  }
  System.Console.WriteLine("\nData stored!!");
  write.Close();
  
}

// display csv data 
 static void Display()
 {
    StreamReader read = null;
    List<StudentDetails> listA = new List<StudentDetails>();
    if(File.Exists("Data.csv"))
    {
        read = new StreamReader(File.OpenRead("Data.csv"));
        while(!read.EndOfStream)
        {
            var line = read.ReadLine();
            var values = line.Split(',');
            if(values[0] != "")
            {
                listA.Add(new StudentDetails(){Name = values[0], FatherName = values[1],Gender = Enum.Parse<Gender>(values[2]),DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
            }
        }
    }
    else 
    {
        System.Console.WriteLine("File Dosn't Exist");
    }
    read.Close();
    System.Console.WriteLine("\nYour data are listed Below");
    System.Console.WriteLine("--------------------------------------------------------------------------------------------------");
    foreach (var item in listA)
    {
        System.Console.WriteLine(" Your Name:\t"+item.Name+"\tFather Name:\t"+item.FatherName+"\tGender:\t"+item.Gender+"\tDOB:\t"+item.DOB+"");
    }
    System.Console.WriteLine("--------------------------------------------------------------------------------------------------");

 }


}
}
