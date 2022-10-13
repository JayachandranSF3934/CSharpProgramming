using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StudentData
{
    public static class StudentInfo    // Static Class
    {
        public static string Name { get; set; } //  Static Property 
        public static int RegisterNumber; // Static Fields
        static StudentInfo ()     // Static Default Constructor , Dont use Public , Use static  in constructor
        {
             Name = "Jayachandran";
             RegisterNumber = 199923;
        }
        public static void ShowDetails()  // Static Method
        {
            System.Console.WriteLine($"\n\nName is {Name}\n\nRegisterNumber is {RegisterNumber}\n\n");
        }

        

    }
}