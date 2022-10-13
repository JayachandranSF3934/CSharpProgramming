using System;

namespace MovieTicket
{
    // delegate
    public delegate void EventManager();
    public class Operation
    {
        // Event Fields
        private static event EventManager eventLinker = null;
        //curent user 
        static UserDetails currentUser ;
        static TheatreDetails currentTheatre;
        // creating list for users
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<TheatreDetails> theatreList =new List<TheatreDetails>();
        public static List<MovieDetails> movieList = new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList = new List<ScreeningDetails>();    


        // Event 
        public static void Subscribe()
        {
            eventLinker += new EventManager(Files.Create);
            eventLinker += new EventManager(Files.Read);
            eventLinker += new EventManager(Operation.MainMenu);
            eventLinker += new EventManager(Files.Write);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventLinker();
        }
        //MainMenu
        public static void MainMenu()
        {
            //Default();
            System.Console.WriteLine("<<<<<<<<<<------------------------------------------------------------------->>>>>>>>>>");
            System.Console.WriteLine("<<<<<<<<<<--------Welcome To Online Theatre Ticket Booking Application------->>>>>>>>>>");
            System.Console.WriteLine("<<<<<<<<<<------------------------------------------------------------------->>>>>>>>>>\n");
            string input ="yes";
            do
            {
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<--------Now Showing MainMenu---------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("\n\tSELECT OPTION\n\n1.User Registraion\n2.Login\n3.Exit");
                /*try
                {

                }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                } 
                */
                try
                {
                System.Console.WriteLine("Enter Your Option");
                int options = int.Parse(Console.ReadLine());

                switch(options)
                {
                    case 1 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-----------USER REGISTRATION---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        UserRegistration();
                        break;
                    }
                    case 2 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<---------------USER LOGIN------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        Login();
                        break;
                    }
                    case 3 :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-----------Exited From Application---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<--------------------------------------------->>>>>>>>>>");
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


        // User Registraion 
        public static void UserRegistration()
        {
            try{
            System.Console.WriteLine("\nEnter Your name: ");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("\nEnter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nEnter Your Phone Number: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            // creating user object and to user list
            UserDetails user = new UserDetails(name,age,phoneNumber);
            userList.Add(user);

            // showing user ID to user
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            System.Console.WriteLine("        You Are SuccessFully Registered With US           ");
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            
            
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            System.Console.WriteLine($"              Your User ID is {user.UserID}              ");
            System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
            }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }

        }

        //Login
        public static void Login()
        {
            try
            {
            System.Console.WriteLine("Enter Your UserID to Login :");
            string userID = Console.ReadLine().ToUpper();
            
            bool flag =true;
            foreach (UserDetails users in userList)
            {
                if(users.UserID == userID)
                {
                    currentUser  =users;
                    System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                    System.Console.WriteLine("              You are Succesfully Logged In!!!                  ");
                     System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                    flag = false;
                    SubMenu();
                }
            }
            if(flag == true)
            {
                System.Console.WriteLine("\nInvalid User ID\n");
                Login();
            }
            }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
        }

        //SubMenu

        public static void SubMenu()
        {
            string input = "yes";
            do
            {
                System.Console.WriteLine("\n<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<-------- NOW SHOWING SUBMENU---------->>>>>>>>>>");
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                try
                {
                System.Console.WriteLine("\n\tSELECT OPTION\n\na.Ticket Booking\nb.Ticket Cancellation\nc.Booking History\nd.Wallet Rechargee.\ne.Exit");
                char options = char.Parse(Console.ReadLine().ToLower());

                switch(options)
                {
                    case 'a' :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<----------- TICKET BOOKING ---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        TicketBooking();
                        
                        break;
                    }
                    case 'b' :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<---------TICKET CANCELLATION---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        TicketCancellation();
                        
                        break;
                    }
                    case 'c' :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<------------BOOKING HISTORY----------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        BookingHistory();
                        
                        break;
                    }
                    case 'd' :
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------WALLET RECHARGE---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        currentUser.RechargeWallet();                        
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<-----------  EXIT FROM SUBMENU  ---------->>>>>>>>>>");
                        System.Console.WriteLine("<<<<<<<<<<--------------------------------------------->>>>>>>>>>\n\n");
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

        // Booking Ticket
        public static void TicketBooking()
        {
            double totalAmount =0;
            //1.Once the User logged in show the list of Theatre’s details.
            System.Console.WriteLine("SHOWING THEATRE DETAILS\n");
            foreach(TheatreDetails theatres in theatreList)
            {
                System.Console.WriteLine($"Theatre ID:{theatres.TheatreID}	Theatre Name:{theatres.TheatreName}	TheatreLocation:{theatres.TheatreLocation}");
            }
            //Ask the user to select a Theatre using Theatre ID. 
            try
            {
            System.Console.WriteLine("\n Select Theatre ID From The Above List:");
            string theatreID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (TheatreDetails theatre in theatreList)
            {
                if(theatre.TheatreID == theatreID)
                {  currentTheatre =theatre;
                    flag = false;
                    //Once Theatre selected then Show the user, the detailed list of movies screened on that theatre.
                    System.Console.WriteLine("\nSHOWING SCREENING DETAILS\n");
                    foreach (ScreeningDetails screens in screeningList)
                    {
                        if(currentTheatre.TheatreID == screens.TheatreID)
                        {
                            System.Console.WriteLine($"Movie Id:{screens.MovieID}	TheatreID:{screens.TheatreID}	Ticket Price:{screens.TicketPrice}	Seat Availability:{screens.NoOfSeatsAvailable}");
                        }    
                        
                    }
                    //4.	Ask the user to select a movie from list of screened movies using MovieID.
                    //5.	Ask for the count of seats he wish to Book.
                    System.Console.WriteLine("\nSelect A Movie ID Form the Above Screening List ");
                    string movieId = Console.ReadLine().ToUpper();
                    System.Console.WriteLine("\nEnter the Number Of Seats Do you want to book ");
                    int seatCount = int.Parse(Console.ReadLine());

                    //6.	If the required count is not available in the Theatre seat availability, 
                    //then show like “Required Seat count not available. Current availability is {Seat count}”.
                    //7.	If the seat count is available, then calculate total amount with the below formula.
                    //   Total Amount = (required count * price per ticket) +18% tax in total ticket price 
                    bool flag1 =true;
                    bool flag2= true;
                    foreach (ScreeningDetails screen in screeningList)
                    {
                        if(movieId == screen.MovieID && seatCount >=screen.NoOfSeatsAvailable && screen.NoOfSeatsAvailable !=0)
                        {
                            flag1 =false;
                            double total = (seatCount*screen.TicketPrice);
                            double gst = total*0.18;
                            totalAmount = total+gst;
                            while(currentUser.WalletBalance >= totalAmount)
                            {
                                /*8.	Check the current logged in user’s wallet balance to ensure he is having enough balance to book ticket by comparing with total price.
                            9.	If the wallet balance is insufficient for this booking, then display “Insufficient Wallet Balance. Please recharge your wallet”.
                            10.	If the wallet has sufficient balance, then 
                            a.	Deduct the total amount from the wallet balance of the current logged in user.
                            b.	Deduct the count from the seat availability of the movie. */
                                flag2 = false;
                                currentUser.WalletBalance -= totalAmount;
                                screen.NoOfSeatsAvailable -= seatCount;
                                /* and confirm the order, Set Booking status as Booked and create booking object, file it and show “Booking successful”.*/
                                BookingDetails newBooking =  new BookingDetails(currentUser.UserID,movieId,currentTheatre.TheatreID,seatCount,totalAmount,BookingStatus.Booked);
                                bookingList.Add(newBooking);
                                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                                System.Console.WriteLine("<<<<<----You Moive Ticket was Booked SuccessFully----->>>>>");
                                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                                System.Console.WriteLine($"        Your Booking Id Is {newBooking.BookingID}");
                                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                                break;
                            }   
                        }
                    }
                    if(flag1 == true)
                    {
                        System.Console.WriteLine("Invalid Movie ID    or    Required Seat count is Not Available");
                        TicketBooking();
                       
                    }
                    if(flag2 == true)
                    {
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                        System.Console.WriteLine("          Insufficient Wallet Balance  \n               Recharge your wallet");
                        System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                        currentUser.RechargeWallet();
                        TicketBooking();
                    }
                }
            }
            
            if(flag == true)
            {
                System.Console.WriteLine("Invalid Theatre ID");
            }
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }

        //Cancel booking

        
        public static void TicketCancellation()
        {
            try
            {
            // 1.Show the booking history of current logged in user
            bool temp =true;
            foreach (BookingDetails bookings in bookingList)
            {
               if(currentUser.UserID == bookings.UserID && bookings.BookingStatuses == BookingStatus.Booked)
               { temp = false;
                  System.Console.WriteLine($"Booking ID :{bookings.BookingID}	UserID:{bookings.UserID}	MovieID:{bookings.MovieID}	TheatreID:{bookings.TheatreID}	SeatCount:{bookings.SeatCount}	TotalAmount:{bookings.TotalAmount}	BookingStatus:{bookings.BookingStatuses}");
               }
            }
            if(temp == true)
            {
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>");
                System.Console.WriteLine("You Have No Booking History");
                System.Console.WriteLine("<<<<<<<<<<-------------------------------------->>>>>>>>>>\n");
                System.Console.WriteLine("Do you want to Book Tickets for New Released Movie  YES or NO??");
                string input = Console.ReadLine().ToLower();
                if(input == "yes")
                {
                    TicketBooking();
                }
            }
            // 2.	Ask the booking ID he want to cancel. 
            System.Console.WriteLine("Select the booking ID Do you want to cancel :");
            string bookID =Console.ReadLine().ToUpper();

            // 3.	Check the status of booking if it is “Booked” then
            bool flag= true;
            foreach (BookingDetails booked in bookingList)
            {
                if(currentUser.UserID == booked.UserID && booked.BookingStatuses == BookingStatus.Booked)
                {
                    /* 
            5.	Reduce 20 Rs amount from total amount and add the remaining amount to user’s wallet balance
            6.	Change the booking status to cancelled.  */
                    double totalAfterDedution = booked.TotalAmount +20;
                    currentUser.WalletBalance  += totalAfterDedution;
                    booked.BookingStatuses = BookingStatus.Cancelled;
                    int count = booked.SeatCount;
                    booked.SeatCount -= count;
                    flag = false;     
                }
            }
            if(flag == false)
            {
                System.Console.WriteLine("Your Booking Was Cancelled Sucessfully!!!");
            }
            }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
        } 
        public static void BookingHistory()
        {
            bool flag = true;
            foreach (BookingDetails bookings in bookingList)
            {
               if(currentUser.UserID == bookings.UserID)
               {
                  flag = false;
                  System.Console.WriteLine($"Booking ID :{bookings.BookingID}	UserID:{bookings.UserID}	MovieID:{bookings.MovieID}	TheatreID:{bookings.TheatreID}	SeatCount:{bookings.SeatCount}	TotalAmount:{bookings.TotalAmount}	BookingStatus:{bookings.BookingStatuses}");
               }
            }
            if(flag == true)
            {
                try
                { 
                System.Console.WriteLine("You Have No Booking History \n");
                System.Console.WriteLine("Do you want to Book Tickets for New Released Movie  YES or NO??");
                string input = Console.ReadLine().ToLower();
                if(input == "yes")
                {
                    TicketBooking();
                }
                }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }    
            }
        }

        //Default data
        public static void Default()
        {
            //user details
            UserDetails user1 =new UserDetails("Ravichandran",30,859948803);
            UserDetails user2 =new UserDetails("Baskaran",30,8599444803);
            userList.Add(user1);
            userList.Add(user2);
            //booking details
            
            BookingDetails booking1 =new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
            BookingDetails booking2 =new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
            BookingDetails booking3 =new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
            bookingList.Add(booking1);bookingList.Add(booking2);bookingList.Add(booking3);

            //Theatre Details
            
            TheatreDetails theatre1 =new TheatreDetails("Inox","Anna Nagar");
            TheatreDetails theatre2 =new TheatreDetails("Ega Theatre","Chetpet");
            TheatreDetails theatre3 =new TheatreDetails("Kamala","Vadapalani");
            theatreList.Add(theatre1);theatreList.Add(theatre2);theatreList.Add(theatre3);

            //Movie details
           
            MovieDetails movie1 = new MovieDetails("Bagubali 2","Tamil");
            MovieDetails movie2 = new MovieDetails("Ponniyin Selvan ","Tamil");
            MovieDetails movie3 = new MovieDetails("Cobra ","Tamil");
            MovieDetails movie4 = new MovieDetails("Vikram 1","Hindi (Dubbed)");
            MovieDetails movie5 = new MovieDetails("Beast ","Tamil");
            movieList.Add(movie1);movieList.Add(movie2);movieList.Add(movie3);movieList.Add(movie4);movieList.Add(movie5);

            //Screening Details

            ScreeningDetails screen1 =new ScreeningDetails("MID501","TID301",200,2);
            ScreeningDetails screen2 =new ScreeningDetails("MID502","TID301",300,2);
            ScreeningDetails screen3 =new ScreeningDetails("MID506","TID301",50,1);
            ScreeningDetails screen4 =new ScreeningDetails("MID501","TID302",400,11);
            ScreeningDetails screen5 =new ScreeningDetails("MID502","TID302",300,20);
            ScreeningDetails screen6 =new ScreeningDetails("MID504","TID302",500,2);
            ScreeningDetails screen7 =new ScreeningDetails("MID505","TID303",100,11);
            ScreeningDetails screen8 =new ScreeningDetails("MID502","TID303",200,20);
            ScreeningDetails screen9 =new ScreeningDetails("MID504","TID303",350,2);
            screeningList.Add(screen1);screeningList.Add(screen2);screeningList.Add(screen3);screeningList.Add(screen4);screeningList.Add(screen5);screeningList.Add(screen6);screeningList.Add(screen7);screeningList.Add(screen8);screeningList.Add(screen9);
           }
    }
}