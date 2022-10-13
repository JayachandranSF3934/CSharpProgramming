using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public static class Operation
    {  
        // Creating Empty Object for user, bookdetail, and borrow details
        static UserDetails currentUser =null;
        static BookDetails selectedBook = null;
        static BorrowDetails borrowedBook = null;


        // Creating List for userdetails , Bookdetails, BorrowDetails
        static List<UserDetails> userlist = new List<UserDetails>();

        static List<BookDetails> bookList = new List<BookDetails>();

        static List<BorrowDetails> borrowList =  new List<BorrowDetails>();

    

    // Mainmenu To Show list of operations to performed

    public static void MainMenu()
    {
        // Calling Default Method to Add Default values to the  Paticular list
        Default();
        // welcome greeting
        System.Console.WriteLine("\t\tWelcome To Book Bank Application");
        System.Console.WriteLine("Select Any One Of the Given Option Below To Proceed Furthur ");
        string input = "yes";
        do
        {
            System.Console.WriteLine("\n1.User Register\n2.User Login \n3.Exit");
             int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                {
                  System.Console.WriteLine("User Registeration");
                  UserRegister();
                  break;
                }

                case 2:
                {
                    System.Console.WriteLine("User Login");
                    UserLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    input ="no";
                    break;
                }
            }

        }while(input == "yes");
    }
    // User Register Method 
    public static void UserRegister()
    {
        System.Console.WriteLine("\t\tWelcome To Registeration Process");

        System.Console.Write("Enter Your Name:");
        string name = Console.ReadLine();

        System.Console.Write("Enter Your Gender:");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.Write("Enter Your Department Name:");
        Department departmentName = Enum.Parse<Department>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Your Mobile Number");
        long mobileNumber =Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter Your mail ID");
        string emailId =Console.ReadLine();
         
        // Add Collected information to List

        UserDetails user =new UserDetails(name,gender,departmentName,mobileNumber,emailId);
        userlist.Add(user);

        System.Console.WriteLine("Your Are Successfully Registered!!!!");
        System.Console.WriteLine($"Your New Register ID is :{user.RegisterId}");
    
    }
     // User Login Method
    public static void UserLogin()
    {
        System.Console.WriteLine("Enter Your Register ID");
        string regId = Console.ReadLine().ToUpper();   
        foreach(UserDetails item in userlist)
        {
            if(item.RegisterId == regId)
            {
                System.Console.WriteLine("\nLogin Successfully!!!");
                currentUser =item;
                // Calling Sub Menu for logined Users
                SubMenu();
            }
            else 
            {
                System.Console.WriteLine("Invalid user Id , Please Enter a Valid One");
                // Calling User Login To Get vaild USer Id
                UserLogin();
            }
        }
    }

    // Submenu Method
    public static void SubMenu()
    {
        System.Console.WriteLine("Select Any one Option To Proceed Furthur ");

        string choice ="yes";
        do
        {
        System.Console.WriteLine("\n1.Borrow Book\n2.Show Borrowed Book History\n3.Return Book\n4.Exit Submenu");
        int numbers = int.Parse(Console.ReadLine());
        switch(numbers)
        {
            case 1:
            {
                System.Console.WriteLine("Welcome To Borrow Book Page ");
                BorrowBook();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Welcome to Show Borrowed history");

                break;
            }
            case 3:
            {
                System.Console.WriteLine("Welcome To Return Book Page");

                break;
            }
            case 4:
            {
                System.Console.WriteLine("Exit SubMenu");
                choice = "no";
                break;
            }
        }
        }while(choice =="yes");
    }


    // BorrowBook Method
    public static void BorrowBook()
    {  
        // Show Available Books
        System.Console.WriteLine("Books Available\n\n");
        foreach (BookDetails item in bookList)
        {
            System.Console.WriteLine($"BookID:{item.BookId} Book Name:{item.BookName} Author Name:{item.AuthorName} Book Count:{item.BookCount} Book Status:{item.Status}");
        }
        // Get Book ID From From user
        System.Console.WriteLine("Enter BookId To Borrow");
        string getBookId = Console.ReadLine();


      /*3.	Check for the book count availability for the book selected. 
            If the there is no book available, display as “Books are not available for the selected count”. 
            Print the next available date of book by getting borrowed history information and adding the borrowed date of that book with 15 days. 
            Show “ The book will be available on 22/04/2002”.  */
           if(selectedBook.BookCount == 0)
           {
            System.Console.WriteLine("Books Are not Available for the Selected Count.");
            System.Console.WriteLine($"The Book Will be available on { borrowedBook.BorrowDate.AddDays(15)}");
           }
      /*4.	If the book is available to borrow, need to check whether the user already borrowed any book.
            Because, user can enroll for 3 books maximum at a time. 
            Else allocate the book under the user and set status of the BookingDetails as "Assigned”.*/
            else
            {
                
            }                

     //5.	If the user borrowed less than 3 books, then they can borrow that book and store the borrowed information to Borrow details list as history.
 
    }

  // ShowBorrowedHistory Method
    public static void ShowBorrowedHistory()
    {

    }
    // Retrun Book Method
    public static void ReturnBook()
    {

    }
    // Default method to 
    public static void Default()
    {  // Add Default User Details in userList
        UserDetails userOne = new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com");
        userlist.Add(userOne);

        UserDetails userTwo = new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com");
        userlist.Add(userTwo);


        // Add Default Book Details in bookList
        BookDetails bookOne = new  BookDetails("BID101","C#","Author1",3,BookStatus.Issued);
        bookList.Add(bookOne);

        BookDetails bookTwo = new  BookDetails("BID102","HTML","Author2",5,BookStatus.Returned);
        bookList.Add(bookTwo);

        BookDetails bookThree = new  BookDetails("BID103","CSS","Author3",3,BookStatus.Issued);
        bookList.Add(bookThree);

        BookDetails bookFour = new  BookDetails("BID104","JAVASCRIPT","Author4",3,BookStatus.Issued);
        bookList.Add(bookFour);

        BookDetails bookFive = new  BookDetails("BID105","TYPESCRIPT","Author5",2,BookStatus.Returned);
        bookList.Add(bookOne);


        // Add Default Borrow Details In BorrowList
        BorrowDetails itemOne = new BorrowDetails("LB301","BID101","SF3001", new DateTime(2022, 04, 10),BookStatus.Issued );
        borrowList.Add(itemOne);

        BorrowDetails itemTwo = new BorrowDetails("LB302","BID103","SF3001", new DateTime(2022, 04, 12),BookStatus.Issued );
        borrowList.Add(itemTwo);

        BorrowDetails itemThree = new BorrowDetails("LB303","BID104","SF3001", new DateTime(2022, 04, 15),BookStatus.Issued );
        borrowList.Add(itemThree);

        BorrowDetails itemFour = new BorrowDetails("LB304","BID102","SF3002", new DateTime(2022, 04, 11),BookStatus.Issued );
        borrowList.Add(itemFour);

        BorrowDetails itemFive = new BorrowDetails("LB301","BID105","SF3001", new DateTime(2022, 04, 15),BookStatus.Issued );
        borrowList.Add(itemFive);
    }
    }
}