using System;
using System.IO;
namespace FileAndFolder{
class Program{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\JayachandranJayasank\OneDrive - Syncfusion\Desktop\MyFolder";   // path of My folder.

        string folderPath = path+"/jai";
        string filePath = path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder Not Found . So Creating Folder");
            Directory.CreateDirectory(folderPath);
        }
        else{
            System.Console.WriteLine("Directory Found");
        }

        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File Not Found, Creating File");
            File.Create(filePath);  
        }
        else {
            System.Console.WriteLine("File Already Exist");
        }


    // Create Swicth Case 
    System.Console.WriteLine("Select Option  \n 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
    int value = int.Parse(Console.ReadLine());

    switch(value)
    {
        case 1:
        {
        System.Console.WriteLine("Enter Folder Name you want to create");
        string folderName = Console.ReadLine();
        string newPath = path+"\\"+folderName;
        if(!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }
        else{
            System.Console.WriteLine("Directory Found");
        }
    
        break;
        }
        case 2:
        {
            System.Console.WriteLine("Enter File Name you want to create");
            string fileName = Console.ReadLine();
            System.Console.WriteLine("Enter File Extension You want to create");
            string extension = Console.ReadLine();
            
            string newPath = path+"\\"+fileName+"."+extension;

            if(!File.Exists(filePath))
            {
                File.Create(filePath);  
            }
            else {
                System.Console.WriteLine("File Name Already Exist");
                }
                break;
        }

        case 3:
        {
           foreach(string name in Directory.GetDirectories(path))
           {
            System.Console.WriteLine(name);
           }
           System.Console.WriteLine("Select folder you want to delete");
           string name1 = Console.ReadLine();
           string newPath = path+"//"+name1;
           foreach(string name in Directory.GetDirectories(path))
           {
            if(name==newPath)  // Check Folder Matches
            {
                try 
                {
                    Directory.Delete(newPath);
                    System.Console.WriteLine("Folder Deleted");
                }catch(DirectoryNotFoundException )
                {
                    System.Console.WriteLine("Directory not FOund");
                }
                
            }
           }
           break;
        }

        case 4:
        {
            foreach(string name in Directory.GetFiles(path))
            {
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine("select File You want to delete");
            string name1 = Console.ReadLine();
            System.Console.WriteLine("Enter File extension you want to delete");
            string name2 = Console.ReadLine();

            string newPath = path+"\\"+name1+"."+name2;

            foreach(string name in Directory.GetFiles(path))
            {
                if(name == newPath)
                {
                    File.Delete(newPath);
                    System.Console.WriteLine("File Deleted");
                }
            }
            break;
        
        }
        
        
    }



    }
}
}
