using System;
namespace Bank{
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Showing Personal Details\n");
        PersonDetails person = new PersonDetails("Jayachandran","Sankar",9822343489,"Jai@gmail.com",new DateTime(2001,09,06),Gender.Male);
        person.ShowPersonDetail();

        //account info 
        System.Console.WriteLine("\nShowing Account Info\n");
        AccountInfo info =new AccountInfo("Vikram","kamal",9822343489,"Jai@gmail.com",new DateTime(2001,09,06),Gender.Male,"SBI-Chennai",34453);
        info.ShowAccountInfo();
    }
}
}
