using System;
namespace MedicalStore{
class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.Read();
        Procedure.ManiMenu();
        Files.Write();
    }
}
}
