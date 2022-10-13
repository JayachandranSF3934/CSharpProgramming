using System;


namespace OnlineGrocery
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int  s_bookingID =3000;
        /* Properties: BookingID, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.
Method: ShowBookingDetails*/
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus Status { get; set; }


        // constructor
        public BookingDetails(string customerID,double totalPrice, DateTime dob,BookingStatus status)
        {
            s_bookingID++;
            BookingID = "BID"+s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking =dob;
            Status = status;
        }

        public BookingDetails(string book)
        {
            string [] values = book.Split(",");
            s_bookingID = int.Parse(values[0].Remove(0,3));
            BookingID = values[0];
            CustomerID =values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Status = Enum.Parse<BookingStatus>(values[4]);

        }

        //method
        public void ShowBookingDetails()
        {
            System.Console.WriteLine($"BookingID:{BookingID}");
            System.Console.WriteLine($" {CustomerID} {TotalPrice} {DateOfBooking} {Status}");
        }
    }

}