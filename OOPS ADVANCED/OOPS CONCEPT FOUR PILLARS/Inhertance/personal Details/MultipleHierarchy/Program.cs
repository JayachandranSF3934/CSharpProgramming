﻿using System;
using System.Collections.Generic;
namespace MultipleHierarchy{
class Program{
    public static void Main(string[] args)
    {
      // object for person 
       PersonalDetails personOne = new PersonalDetails("jai","sankar",Gender.Male,939488443);
       personOne.ShowDetails();
     
     // object for student
     StudentDetails student = new StudentDetails("644456","jai","sanndes",Gender.Male, 3333223322,Department.CSE,"fianl");
     student.ShowStudent();  // Doubt Asked Cleared --- To show details of student object call show Student method which is created in the studentdetails maethod
     // using interface to complete 
     
     student.GetMark(90,89,79);
     student.Calculate();
     student.ShowMark();
    


     // object for customer
     CustomerDetails customer = new CustomerDetails("585858","Jayachandran","kamal",Gender.Male,98985655898);
     customer.Recharge();
     customer.ShowCustomer();

     // object for mark details

       

       
    }
}
}
