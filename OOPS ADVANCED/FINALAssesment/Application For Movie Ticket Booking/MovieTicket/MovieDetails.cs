
namespace MovieTicket
{
    /// <summary>
    /// Movie Details Classes
    /// </summary>
    public class MovieDetails
    {
        /// <summary>
        /// Filed
        /// </summary>
        private static int s_movieID = 1000;
        /// <summary>
        /// Property
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }

        /// <summary>
        /// Movie Details Constructor
        /// </summary>
        /// <param name="moiveName"></param>
        /// <param name="language"></param>
        public MovieDetails(string moiveName,string language)
        {
            s_movieID++;
            MovieID ="MID"+s_movieID;
            MovieName = moiveName;
            Language =language;
        }

        public MovieDetails(string data)
        {
            string[] values = data.Split(",");
            s_movieID = int.Parse(values[0].Remove(0,3));
            MovieID =values[0];
            MovieName = values[1];
            Language = values[2];
        }
       
    }
}