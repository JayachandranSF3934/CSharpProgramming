using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public enum BookingStatus{Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        /* Properties: BookingID, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.
              Method: ShowBookingDetails */
              // fields
        private static int s_bookingID =3000;

        public string BookingID { get; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus Status { get; set; }

        //pConstructor
        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking,BookingStatus status)
        {
            s_bookingID++;
            BookingID = "BID"+s_bookingID;
            CustomerID = customerID;
            TotalPrice =totalPrice;
            DateOfBooking = dateOfBooking;
            Status = status;
        }
        //Files Constructor
        public BookingDetails(string book)
        {
            string [] values = book.Split(",");
            s_bookingID = int.Parse(values[0].Remove(0,3));
            BookingID = values[0];
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Status= Enum.Parse<BookingStatus>(values[4]);
        }

        // Show Booking details Method
        public void ShowBookingDetails()
        {
            System.Console.WriteLine($"Your Booking Number is {BookingID}");
            System.Console.WriteLine($"Booking ID:{BookingID} Customer ID:{CustomerID} Total Price: {TotalPrice} Date OF Booking :{DateOfBooking.ToString("d")}  Booking Status: {Status}");
 
        }


    }
}