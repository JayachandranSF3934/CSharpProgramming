using System;

namespace AppointmentSystem
{
    //delegates
    public delegate void EventManager();
    public class AppointmentManager
    {
        //events
        public static event EventManager appointmentadded = null;
        // createing object
        static Patients currentPatient;
        //creating list for class like doctor, patient, Appoint
        public static List<Doctors> doctorList = new List<Doctors>();
        public static List<Patients> patientList = new List<Patients>();
        public static List<Appointments> appointmentList = new List<Appointments>();

        //subscribe
        public static void Subscribe()
        {
            appointmentadded += new EventManager(Files.Create);
            appointmentadded += new EventManager(Files.Read);
            appointmentadded += new EventManager(AppointmentManager.MainMenu);
            appointmentadded += new EventManager(Files.Write);
        }
        // start event
        public static void StartEvent()
        {
            Subscribe();
            appointmentadded();
        }



        //mainmenu
         public static void MainMenu()
        {
            //Default();
            System.Console.WriteLine("<<<<<<<<<<--------------------------------------------->>>>>>>>>>");
            System.Console.WriteLine("<<<<<<<<<<--------  Appointment Booking System  ------->>>>>>>>>>");
            System.Console.WriteLine("<<<<<<<<<<--------------------------------------------->>>>>>>>>>\n");
            string input ="yes";
            do
            {
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<--------Now Showing MainMenu---------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("\n\tSELECT ANY OPTION\n\n1.Login\n2.Register\n3.Exit");
                try
                {
                System.Console.WriteLine("\nEnter Your Option to Proceed Furthur");
                int options = int.Parse(Console.ReadLine());

                switch(options)
                {
                    case 1 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-----------       LOGIN     ---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        Login();
                        break;
                    }
                    case 2 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<--------------- REGISTER ------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        Register();
                        break;
                    }
                    case 3 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-----------Exited From Application---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<--------------------------------------------->>>>>>>>>>\n");
                        input ="no";
                        break;
                    }
                }
                }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }while(input == "yes");
        }

        //Register
        public static void Register()
        {
             System.Console.WriteLine("\tEnter your details to proceed Further.\n");
            // ask patient details and store in patient list
            try
            {    
            System.Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("Enter Password To Login Your Account Next Time:");
            string password = Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Age in number like(10, 23, 45):");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your Gender: Male , Female");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            //add patient details in patientlist
            Patients patientNew = new Patients(password,name,age,gender);
            patientList.Add(patientNew);
            //show Patient Id 
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            System.Console.WriteLine("        You Are SuccessFully Registered With US           ");
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
            
            
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            System.Console.WriteLine($"       Your Patient ID is {patientNew.PatientID}          ");
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");    
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }  
        }

        //Login
        public static void Login()
        {
            System.Console.WriteLine("\nEnter your Name and Password to Login\n");
            try
            {
            System.Console.WriteLine("Enter Your Name:");
            string userName = Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Password:");
            string userPassword = Console.ReadLine();
            bool flag = true;
            foreach(Patients patients in patientList)
            {
                if(patients.Name == userName && patients.Password == userPassword)
                {
                    currentPatient = patients;
                    System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                    System.Console.WriteLine("              You are Succesfully Logged In!!!                  ");
                    System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>\n");
                    flag = false;
                    PatientMenu();
                }
            }
            if(flag == true)
            {
                System.Console.WriteLine("<<<<<<<<<<--------------------------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("Sorry, your record is invalid. Please register your profile and log in again.");
                System.Console.WriteLine("<<<<<<<<<<--------------------------------------------------------->>>>>>>>>>\n");
                MainMenu();
            }
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        //PatientMenu
        public static void PatientMenu()
        {
            string input = "yes";
            do
            {
                System.Console.WriteLine("\n<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<-------- NOW SHOWING PATIENTMENU-------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<---------------------------------------->>>>>>>>>>\n");
                try
                {
                System.Console.WriteLine("\n\tSELECT ANY OPTION\n\n1.Book Appointment\n2.View Appointment details\n3.Edit my profile\n4.Exit");
                int options = int.Parse(Console.ReadLine());
                switch(options)
                {
                    case 1 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<----------- BOOK APPOINTMENT --------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        BookAppointment(); 
                        break;
                    }
                    case 2 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<----------- VIEW APPOINTMENT --------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        ViewAppointment();  
                        break;
                    }
                    case 3 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<------------EDIT MY PROFILE----------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        EditMyProfile();
                        break;
                    }    
                    case 4:
                    {
                        System.Console.WriteLine("<<<<<<<<<<------------------------------>>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<------------  EXIT ----------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<------------------------------>>>>>>>>>>\n\n");
                        input ="no";
                        break;
                    }
                }
                }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }while(input == "yes");
        }
        //Book appointment
        public static void BookAppointment()
        {
            //show department list
            System.Console.WriteLine("Select the department from the below List:\n");
            foreach (Doctors dept in doctorList)
            {
                System.Console.WriteLine($"{dept.DoctorID}.  {dept.Department}");
            }
            //get department id from user
            try
            {            
            System.Console.WriteLine("\nEnter Department You want to book Appointment:");
            int userInput = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Problem :");
            string userProblem = Console.ReadLine();

            //check doctors availablity and book appointment
            bool flag  = true;
            foreach (Doctors booking in doctorList)
            {
                if(booking.DoctorID == userInput)
                {
                    flag = false;
                    System.Console.WriteLine($"\nYour Appointment is confirmed for the date : {DateTime.Today}\n");
                    System.Console.WriteLine("To book press “Y”, to cancel press “N”. ");
                    char book = char.Parse(Console.ReadLine().ToUpper());
                    if(book == 'Y')
                    {
                        Appointments apt = new Appointments(currentPatient.PatientID,userInput,DateTime.Today,userProblem);
                        appointmentList.Add(apt);
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<----Your Appointment was Booked SuccessFully----->>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine($"       Your Appointment ID is  {apt.AppointmentID}       ");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                    }
                    if(book == 'N')
                    {
                        PatientMenu();
                    }
                }
            }
            if(flag == true)
            {
                System.Console.WriteLine("Enter Vaild Department in the list");
                BookAppointment();
            }
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
        //view appointment
        public static void ViewAppointment()
        {
            System.Console.WriteLine("Your AppointMent Details are Given Below:\n");
            foreach (Appointments ID in appointmentList)
            {
                if(currentPatient.PatientID == ID.PatientID)
                {
                    System.Console.WriteLine($"AppointmentID: {ID.AppointmentID} PatientID: {ID.PatientID} DoctorID: {ID.DoctorID}  Appoint Date: {ID.Date} Problem: {ID.Problem}");
                }
            }
        }
        //editmyprofile
        public static void EditMyProfile()
        {

            string choice ="yes";
            do
            {            
            System.Console.WriteLine("\n\tSelect Options\n1.change Name\n2.Change Password \n3.Change Age \n4.Change Gender \n5.Exit to PatientMenu");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Enter Name to change:"); 
                    string name = Console.ReadLine();
                    currentPatient.Name = name;
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter New password to Modify you old password");
                    string pass = Console.ReadLine();
                    currentPatient.Password = pass;
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Enter Age to modify:");
                    int modifiedAge = int.Parse(Console.ReadLine());
                    currentPatient.Age = modifiedAge;
                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Enter Your Gender: Male , Female");
                    Gender modifiedGender = Enum.Parse<Gender>(Console.ReadLine(),true);
                    currentPatient.Gender = modifiedGender;
                    break;
                    
                }
                
                case 5:
                {
                    System.Console.WriteLine("  \n");
                    choice = "no";
                    break;
                }
            }
            }while(choice == "yes"); 
        }
        //Default Datas
        public static  void Default()
        {
            //doctor Details 
            Doctors doctor1 = new Doctors("Nancy","Anaesthesiology");
            doctorList.Add(doctor1);
            Doctors doctor2 = new Doctors("Andrew","Cardiology");
            doctorList.Add(doctor2);
            Doctors doctor3 = new Doctors("Janet","Diabetology");
            doctorList.Add(doctor3);
            Doctors doctor4 = new Doctors("Margaret","Neonatology");
            doctorList.Add(doctor4);
            Doctors doctor5 = new Doctors("Steven","Nephrology");
            doctorList.Add(doctor5);

            //Patient Details
            Patients patient1 = new Patients("welcome","Robert",40,Gender.Male);
            patientList.Add(patient1);
            Patients patient2 = new Patients("welcome","Laura",36,Gender.Female);
            patientList.Add(patient2);
            Patients patient3 = new Patients("welcome","Anne",42,Gender.Female);
            patientList.Add(patient3);
           
           //Appointment Details
           Appointments appointment1 = new Appointments(1,2,new DateTime(2022,8,3),"Heart problem");
           appointmentList.Add(appointment1);
           Appointments appointment2 = new Appointments(1,5,new DateTime(2022,8,3),"Spinal cord injury");
           appointmentList.Add(appointment2);
           Appointments appointment3 = new Appointments(2,2,new DateTime(2022,8,3),"Heart attack");
           appointmentList.Add(appointment3);
        }

    }
}
