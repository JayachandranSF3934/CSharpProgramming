using System;
namespace AppointmentSystem
{
    public class Doctors
    {
        //field
        private static int s_doctorID = 0;
        //property
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        //constructor
        public Doctors(string name, string department)
        {
            s_doctorID++;
            DoctorID = s_doctorID;
            Name = name;
            Department= department;
        }

        //constructor for File handling
        public Doctors(string data)
        {
            string[] values = data.Split(",");
            s_doctorID = int.Parse(values[0]);
            DoctorID = int.Parse(values[0]);
            Name = values[1];
            Department = values[2];
        }
    }
}