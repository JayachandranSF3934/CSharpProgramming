using System;
using System.Collections.Generic;
namespace FilterDelegates {
class Program{
    public static void Main(string[] args)
    {
        // create objects of person and add to the list
        Person person1 = new Person(){Name = "JAI",Age = 41};
        Person person2 = new Person(){Name = "John",Age = 69};
        Person person3 = new Person(){Name = "dhoni",Age = 12};
        Person person4 = new Person(){Name = "william",Age = 10};
        Person person5 = new Person(){Name = "kane",Age = 30};
        Person person6 = new Person(){Name = "virat",Age = 50};
        // create list and add objects to the list   //personList.Add(person1); or use this way to easyliy add elements
        List<Person> personList = new List<Person>(){person1,person2,person3,person4,person5,person6} ;

        // calling Displaypeople using appriote Delegeate
        DisplayPeople(" Chlidren ",personList, IsChild);
        DisplayPeople(" Adult ",personList,IsAdult);
        DisplayPeople(" Senior ",personList,IsSenior);
        DisplayPeople(" Voter ",personList,IsVoter);



    }

    static void DisplayPeople(string title, List<Person> people,FilterDelegate filter)
    {
        System.Console.WriteLine("People in"+title+"list are\n\n");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine($"{p.Name} is {p.Age} years old");
            }
        }
    }
    // MEthod for Filter Delegates   it is a method baesd on condtion  it is not a property
    static bool IsChild(Person p){ return p.Age >15;}
    static bool IsVoter(Person p){ return p.Age >18;}

    static bool IsAdult(Person p){ if( p.Age >18 && p.Age <50){return true;}else{return false;} ;}

   static bool IsSenior(Person p){return p.Age >50;}

  
    
}
}
