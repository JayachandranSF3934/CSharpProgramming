using System;
namespace SimCard {
class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.Read();
        Procedure.MainMenu();
        Files.Write();
    }
}
}
