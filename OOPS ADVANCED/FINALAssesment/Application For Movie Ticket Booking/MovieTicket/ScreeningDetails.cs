
namespace MovieTicket
{
    /// <summary>
    /// Screenig Details Class
    /// </summary>
    public class ScreeningDetails
    {
        /// <summary>
        /// Property
        /// </summary>
        /// <value> Are Added Default</value>
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int NoOfSeatsAvailable { get; set; }
        public double TicketPrice { get; set; }
        /// <summary>
        /// Constructor Screening Details
        /// </summary>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="noOfSeatsAvailable"></param>
        /// <param name="ticketPrice"></param>
        public ScreeningDetails(string movieID,string theatreID,double ticketPrice ,int noOfSeatsAvailable)
        {
            MovieID = movieID;
            TheatreID = theatreID;
            TicketPrice = ticketPrice;
            NoOfSeatsAvailable =noOfSeatsAvailable;
            
        }
        /// <summary>
        /// Constructor for Files handling  , This is used to Read string type data.
        /// </summary>
        /// <param name="data"></param>
        public ScreeningDetails(string data)
        {
            string[] values = data.Split(",");
            MovieID =values[0];
            TheatreID = values[1];
            TicketPrice = double.Parse(values[2]);
            NoOfSeatsAvailable = int.Parse(values[3]);
        }
        
    }
}