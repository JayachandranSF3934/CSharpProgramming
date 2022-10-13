using System;
namespace BinaryString{
class Program{
    public static void Main(string[] args)
    {
       string[] arrayDefault = new string[]{"SF3921","SF3023","SF3032","SF3054","SF3012","SF3021","SF3041","SF3001","SF3934",};
       // search string
       string searchString = "SF39342";

       // calling BinarySearchString
       BinarySearchString(arrayDefault,searchString);
      
      
      // Binary SearchString method
       void  BinarySearchString(string[] array, string search)
        {
            int start = 0;
            int end = array.Length -1;
            int flag =0;

            while(start <= end)
            {
              int mid = (start+end)/2;
                if(search == array[mid])
                {
                    System.Console.WriteLine("String Present in the string array"); 
                    flag = 1;
                    break;
                }
                else if(string.Compare(search,array[mid])<0)
                {
                    end = mid -1;
                }
                else 
                {
                    start = mid+1;
                }  
            }
            if(flag == 0)
            {
                System.Console.WriteLine("String Not Presented in the String Array");
            }
        } 
    }
}
}
