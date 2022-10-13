using System;
namespace DictionaryDs{
class Program{
    public static void Main(string[] args)
    {
        Dictionary<int,string> data = new Dictionary<int, string>();

        data.Add(55,"JAI");
        
        

        foreach (var item in data)
          {
            System.Console.WriteLine(data);
          }


    }
}
}
