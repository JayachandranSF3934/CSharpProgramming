using System;
using System.Collections.Generic;
namespace SingleInheritance{
class Program{
    public static void Main(string[] args)
    {
       
       
       PersonalDetails personOne = new PersonalDetails("jai","sankar",Gender.Male,939488443);
       personOne.ShowDetails();
     
     // 
     StudentDetails student = new StudentDetails("644456","jai","ja",Gender.Male, 3333223322,Department.CSE,"final");
     student.ShowStudent();
       

       
    }
}
}
