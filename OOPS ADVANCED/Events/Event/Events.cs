using System;


namespace Event
{
    public delegate void EventManager();  // user defined delegates
    public class Events
    {
        // Feild
        private  string _eventName;
        public static event EventManager eventlink = null;  // User Defined Event   Eventlink is a object.

        static int i;

        // parametrized Conatructor

        public Events(string eventName)
        {
            _eventName = eventName;
        }

        // Handle Event Method

        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registeration");
            System.Console.WriteLine("Staring the Follwing The Event");
            eventlink();   // Event Trigger  -> Like Clicking a Button 
        }
        
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine("Event N0:"+i+"  is: "+_eventName+" Started");
        }


    }
}