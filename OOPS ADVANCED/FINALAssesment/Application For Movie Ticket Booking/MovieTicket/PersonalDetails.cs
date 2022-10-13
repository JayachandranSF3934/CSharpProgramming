/// <summary>
/// MOvie Ticket Application
/// </summary>
namespace MovieTicket
{
    /// <summary>
    /// Personal Details Class 
    /// </summary>
    public class PersonalDetails
    {
        //Property
        /// <summary>
        /// properties Name, Age,PhoneNumber
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }

        //Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PersonalDetails()
        {

        }
        /// <summary>
        /// Constructor  Store the Below datas in Personal Details
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string  name, int age, long phoneNumber)
        {
            Name =name;
            Age = age;
            PhoneNumber = phoneNumber;

        }
    }
}