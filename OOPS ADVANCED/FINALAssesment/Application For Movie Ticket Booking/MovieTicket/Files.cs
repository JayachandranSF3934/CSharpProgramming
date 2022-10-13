using System.IO;

namespace MovieTicket
{
    public static class Files
    {
        //create files
        public static void Create()
        {
            //create folder
            if(!Directory.Exists("MovieTicket"))
            {
                System.Console.WriteLine("creating Folder for Movie Ticket");
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating Files for User Details.");
                File.Create("MovieTicket/UserDetails.csv");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating Files for Booking Details.");
                File.Create("MovieTicket/BookingDetails.csv");
            }
            if(!File.Exists("MovieTicket/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating Files for Theatre Details.");
                File.Create("MovieTicket/TheatreDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating Files for Movie Details .");
                File.Create("MovieTicket/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating Files for Screening Details .");
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
        }

        //Read Files
        public static void Read()
        {
            // to read User Details
            string[] users = File.ReadAllLines("MovieTicket/UserDetails.csv");
            foreach (string data in users)
            {
                UserDetails user = new UserDetails(data);
                Operation.userList.Add(user);
            }
            // to read Booking Details
            string[] bookings = File.ReadAllLines("MovieTicket/BookingDetails.csv");
            foreach (string value in bookings)
            {
                BookingDetails booking =  new BookingDetails(value);
                Operation.bookingList.Add(booking);
            }
            //to read Theatre Details
            string[] theatres = File.ReadAllLines("MovieTicket/TheatreDetails.csv");
            foreach (string item in theatres)
            {
                TheatreDetails theatre = new TheatreDetails(item);
                Operation.theatreList.Add(theatre);
            }
            // to read Movie details
            string[] movies = File.ReadAllLines("MovieTicket/MovieDetails.csv");

            foreach (string item in movies)
            {
                MovieDetails movie = new MovieDetails(item);
                Operation.movieList.Add(movie);
            }

            //to read Screening Details
            string[] screenings = File.ReadAllLines("MovieTicket/ScreeningDetails.csv");
            foreach (string times in screenings)
            {
                ScreeningDetails screening = new ScreeningDetails(times);
                Operation.screeningList.Add(screening);
            }
        }

        //Write Files
        public static void Write()
        {
            //write to user details
            string[] userDetails =  new string[Operation.userList.Count];

            for(int i=0;i<Operation.userList.Count;i++)
            {
                userDetails[i] = Operation.userList[i].UserID+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
            }File.WriteAllLines("MovieTicket/UserDetails.csv",userDetails);

            //Write to  Booking Details
            string[] bookingDetails =  new string[Operation.bookingList.Count];

            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                bookingDetails[i] = Operation.bookingList[i].BookingID+","+Operation.bookingList[i].UserID+","+Operation.bookingList[i].MovieID+","+Operation.bookingList[i].TheatreID+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatuses;
            }File.WriteAllLines("MovieTicket/BookingDetails.csv",bookingDetails);
            
            //Write to Theatre Details
            string[] theatreDetails =  new string[Operation.theatreList.Count];

            for(int i=0;i<Operation.theatreList.Count;i++)
            {
                theatreDetails[i] = Operation.theatreList[i].TheatreID+","+Operation.theatreList[i].TheatreName+","+Operation.theatreList[i].TheatreLocation;
            }File.WriteAllLines("MovieTicket/TheatreDetails.csv",theatreDetails);

            //Write to Movie Details
            string[] movieDetails =  new string[Operation.movieList.Count];

            for(int i=0;i<Operation.movieList.Count;i++)
            { 
                movieDetails[i]= Operation.movieList[i].MovieID+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].Language;
            }File.WriteAllLines("MovieTicket/MovieDetails.csv",movieDetails);   

            //write to Screening Details
            string[] screeningDetails =  new string[Operation.screeningList.Count];

            for(int i=0;i<Operation.screeningList.Count;i++)
            { 
                screeningDetails[i] = Operation.screeningList[i].MovieID+","+Operation.screeningList[i].TheatreID+","+Operation.screeningList[i].TicketPrice+","+Operation.screeningList[i].NoOfSeatsAvailable;
            }File.WriteAllLines("MovieTicket/ScreeningDetails.csv",screeningDetails); 

             
        }
    }
}