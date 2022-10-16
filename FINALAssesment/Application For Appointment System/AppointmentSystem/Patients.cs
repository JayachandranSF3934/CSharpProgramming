using System;
namespace AppointmentSystem
{
    //enum
    public enum Gender{Default,Male,Female}
    public class Patients
    {
        //fields
        private static int s_patientID = 0;

        //property
        public int PatientID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        //constructor
        public Patients(string password,string name, int age, Gender gender)
        {
            s_patientID++;
            PatientID = s_patientID;
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
        }

        //constructor for files
        public Patients(string data)
        {
            string[] values = data.Split(",");
            s_patientID = int.Parse(values[0]);
            PatientID = int.Parse(values[0]);
            Password = values[1];
            Name = values[2];
            Age = int.Parse(values[3]);
            Gender =Enum.Parse<Gender>(values[4]);

        }
    }
}