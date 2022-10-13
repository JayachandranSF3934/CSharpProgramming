using System;
using System.IO;
namespace ReadWriteTxtFiles{
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
            System.Console.WriteLine("Folder Exist");
        }

        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else{
            System.Console.WriteLine("File Exist");
        }


        // main for file read and file write

        System.Console.WriteLine("Select options \n1. File Read \n2.File Write");
        int number = int.Parse(Console.ReadLine());

        switch(number)
        {
            case 1:
            {
                System.Console.WriteLine("File Read");

                string line;
                StreamReader sr =null;

                try{
                    sr =new StreamReader("TestFolder/Test.txt");
                    line = sr.ReadLine();
                    while(line !=null)
                    {
                        System.Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }catch(Exception e){System.Console.WriteLine("Exception: "+e.Message);}
                finally
                {
                    if(sr != null)
                    {
                        System.Console.WriteLine("Executing Finally block"); 
                        sr.Close();
                    }
                }
                break;
            }

            case 2:
            {
                StreamWriter sw =null;  // streamreader oject 
                try
                {
                    string [] old = File.ReadAllLines("TestFolder/Test.txt");
                    sw = new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new Content to be placed in file");
                    string info = Console.ReadLine();
                    
                    string old1 = " ";

                    foreach(string text in old)
                    {
                        old1 = old1+"\n"+text;  // append old text info
                    } 

                        old1 = old1+"\n"+info;    // append our input text

                        sw.WriteLine(old1);  // Write  text in file
                    
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }finally
                {
                    if(sw != null) 
                    sw.Close();
                }
            }break;
        }
    }
}
}
