
namespace MovieTicket
{
    /// <summary>
    /// Theatre Detail Class
    /// </summary>
    public class TheatreDetails
    {
       /// <summary>
       /// theatre ID AutoIncrement
       /// </summary>
        private static int s_theatreID = 300;
       
       /// <summary>
       /// Theatre Property
       /// </summary>
       /// <value></value>
        public string TheatreID { get; set; }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="theatreName"></param>
        /// <param name="theatreLocation"></param>
        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreID++;
            TheatreID ="TID"+s_theatreID;
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;     
        }
        /// <summary>
        /// Construcor for Theatre Details to read files
        /// </summary>
        /// <param name="data"></param>
        public TheatreDetails(string data)
        {
            string[] values = data.Split(",");
            s_theatreID = int .Parse(values[0].Remove(0,3));
            TheatreID = values[0];
            TheatreName= values[1];
            TheatreLocation = values[2];
        }
       

    }
}