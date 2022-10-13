using System;
using System.Collections.Generic;
namespace Employement{
class Program{
    public static void Main(string[] args)
    {
       // List<PersonalDetails> details = new List<PersonalDetails>();
       
       PersonalDetails personOne = new PersonalDetails("jai","sankar",Gender.Male,939488443);
       personOne.ShowDetails();
       
    }
}
}
