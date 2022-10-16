using System.IO;
namespace AppointmentSystem
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("AppointmentSystem"))
            {
                System.Console.WriteLine("Creating Appointment System Folder");
                Directory.CreateDirectory("AppointmentSystem");        // creating AppointmentSystem Folder 
            }
            if(!File.Exists("AppointmentSystem/Doctors.csv"))
            {
                System.Console.WriteLine("Doctors File Created");
                File.Create("AppointmentSystem/Doctors.csv");      // creating Files for Doctor 
            }
            if(!File.Exists("AppointmentSystem/Patients.csv"))
            {
                System.Console.WriteLine("Patients File Created");  // creating Files for Patient
                File.Create("AppointmentSystem/Patients.csv");
            }
            if(!File.Exists("AppointmentSystem/Appointments.csv"))
            {
                System.Console.WriteLine("Appointments File Created");  // Creating Files for Appointment Details
                File.Create("AppointmentSystem/Appointments.csv");
            }
        }

        public static void Read()
        {
            // read doctors file
            string[] doctors = File.ReadAllLines("AppointmentSystem/Doctors.csv");
            foreach (var doc in doctors)
            {
                Doctors doctor = new Doctors(doc);
                AppointmentManager.doctorList.Add(doctor);
            }

            //read Patient file
            string[] patients  =File.ReadAllLines("AppointmentSystem/Patients.csv");
            foreach (var pat in patients)
            {
                Patients patient = new Patients(pat);
                AppointmentManager.patientList.Add(patient);
            }

            //read Appointment file
            string[] appointments =File.ReadAllLines("AppointmentSystem/Appointments.csv");
            foreach (var appoint in appointments)
            {
                Appointments appointment = new Appointments(appoint);
                AppointmentManager.appointmentList.Add(appointment);
            }
        }

        public static void Write()
        {
            //to write Doctors files
            string[] doctors = new string[AppointmentManager.doctorList.Count];

            for(int i=0;i<AppointmentManager.doctorList.Count;i++)
            {
                doctors[i] = AppointmentManager.doctorList[i].DoctorID+","+AppointmentManager.doctorList[i].Name+","+AppointmentManager.doctorList[i].Department;
            }File.WriteAllLines("AppointmentSystem/Doctors.csv",doctors);

            //to write Patient files
            string[] patients = new string[AppointmentManager.patientList.Count];

            for(int i=0;i<AppointmentManager.patientList.Count;i++)
            {
                patients[i] = AppointmentManager.patientList[i].PatientID+","+AppointmentManager.patientList[i].Password+","+AppointmentManager.patientList[i].Name+","+AppointmentManager.patientList[i].Age+","+AppointmentManager.patientList[i].Gender;
            }File.WriteAllLines("AppointmentSystem/Patients.csv",patients);

            //to write Appointment files
            string[] appointments = new string[AppointmentManager.appointmentList.Count];
            for(int i=0;i<AppointmentManager.appointmentList.Count;i++)
            {
                appointments[i] = AppointmentManager.appointmentList[i].AppointmentID+","+AppointmentManager.appointmentList[i].PatientID +","+AppointmentManager.appointmentList[i].DoctorID+","+AppointmentManager.appointmentList[i].Date.ToString("dd/MM/yyyy")+","+AppointmentManager.appointmentList[i].Problem;
            }File.WriteAllLines("AppointmentSystem/Appointments.csv",appointments);
        }
        
    }
}