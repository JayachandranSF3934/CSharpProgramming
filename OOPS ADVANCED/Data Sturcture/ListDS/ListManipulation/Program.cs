using System;
namespace ListManipulation{
class Program{
    public static void Main(string[] args)
    {
         List<int> datas = new List<int>();
          datas.Add(10);
          datas.Add(31);
          datas.Add(22);
          datas.Add(20);
          datas.Add(11);
          datas.Add(33);
          datas.Insert(1,23);
          datas.Remove(10);
          datas.RemoveAt(2);

          foreach (int item in datas)
          {
            System.Console.WriteLine(datas);
          }

          // in c# Foreach doesn't run it gives enumerator error.

          for(int i=0;i<datas.Count;i++)
          {
            System.Console.WriteLine(datas[i]);
          }
         
    }
}
}
