using System;


namespace MovieTicket
{
    /// <summary>
    /// Enum Values for Booking Status are decalared Here
    /// </summary>
    public enum BookingStatus{Default,Booked,Cancelled}
    /// <summary>
    /// Booking Details Class
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// Feild fro booking ID
        /// </summary>
        
        private static int s_bookingID = 7000;
        
        /// <summary>
        /// Constructor for Booking Details class
        /// </summary>
        /// <value></value>
        public string BookingID { get; set; }
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public BookingStatus BookingStatuses { get; set; }

        //constructor
        /// <summary>
        /// paramterized Constructor   for Booking Details
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="seatCount"></param>
        /// <param name="totalAmount"></param>
        /// <param name="bookingStatus"></param>
        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID = "BID"+s_bookingID;
            UserID = userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount= seatCount;
            TotalAmount = totalAmount;
            BookingStatuses = bookingStatus;
        }
            /// <summary>
            /// Constructor For Files to read Single Data
            /// </summary>
            /// <param name="data"></param>
        public BookingDetails(string data)
        {
            string[] values = data.Split(",");
            s_bookingID = int.Parse(values[0].Remove(0,3));
            BookingID =values[0];
            UserID =values[1];
            MovieID = values[2];
            TheatreID = values[3];
            SeatCount = int.Parse(values[4]);
            TotalAmount = double.Parse(values[5]);
            BookingStatuses = Enum.Parse<BookingStatus>(values[6]);
        }

    }
}