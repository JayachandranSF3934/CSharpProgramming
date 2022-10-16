using System;


namespace AppointmentSystem
{
    public class Appointments
    {
        //fields
        private static int s_appointmentID = 0;

        //property
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }
        //Constructor

        public Appointments(int patientID,int doctorID ,DateTime date,string problem)
        {
            s_appointmentID++;
            AppointmentID = s_appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Date = date;
            Problem = problem;
        }

        //constructor for files.
        public Appointments(string data)
        {
            string[] values = data.Split(",");
            s_appointmentID = int.Parse(values[0]);
            AppointmentID = int.Parse(values[0]);
            PatientID = int.Parse(values[1]);
            DoctorID = int.Parse(values[2]);
            Date = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Problem = values[4];


        }
    }
}