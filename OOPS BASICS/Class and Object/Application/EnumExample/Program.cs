using System;
namespace EnumExample{
// Enum Decalaration
public enum Gender{Default,Male,Female,Trangender}
class Program{
    public static void Main(string[] args)
    {
         // Enum Option 
         System.Console.WriteLine("Select Gender Option  Male,Female,Transgender");
         Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);  // true will ignore case
         System.Console.WriteLine(gender);

         // select by string or Number

         System.Console.WriteLine("Select Gender Option Male,Female,Transgender");
         Gender gender1 =Gender.Default;
         bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true, out gender1); // True will ignore case
         while(!temp || !((int)gender1<4 && (int)gender1>0))
         {
            System.Console.WriteLine("Invalid Gender \n Enter Again :");
            temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender1 );
         }
         System.Console.WriteLine(gender1);
    }
}
}
