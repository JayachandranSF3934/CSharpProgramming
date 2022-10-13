using System;
namespace Event {
class Program{
    public static void Main(string[] args)
    {
        Events event1 = new Events("Quiz");
        Events event2 = new Events("Debugging");
        Events event3 = new Events("Presentation");
        Events event4 = new Events("Games");
        // Subscribe to events    // += is uesd to add next next Events in the Parallel run.
        Events.eventlink += new EventManager(event1.ShowEvent);
        Events.eventlink += new EventManager(event2.ShowEvent);
        Events.eventlink += new EventManager(event3.ShowEvent);
        Events.eventlink += new EventManager(event4.ShowEvent);


        Events.HandleEvent();   // Calling / Intializing 


        // To unsubscribe  Event 
        Events.eventlink -= new EventManager(event4.ShowEvent);   // To unsubscribe  -= is used to reduce the events in the subscribe  list.


    }
}
}
