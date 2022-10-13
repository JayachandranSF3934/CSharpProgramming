using System;
namespace SealedMethods
{
class Program{
    public static void Main(string[] args)
    {
        Dog god = new Dog();
        god.MakeSound();
        Puppy pup = new Puppy();
        pup.MakeSound();
       
       
    }
}
}
