using System;


namespace Queue
{
    public partial class Queue<Type>
    {
        //Fields
        private int _count;
        private int _capacity;
        private int _head;
        private int _tail;

        private Type[] Array{get;set;}

        public int Count { get; set; }
        public int Capacity { get; set; }
      
      // Constructor
        public Queue()
        {
            _head =0;
            _tail =0;
            _count =0;
            _capacity =4;
            Array =new Type[_capacity];
        }
        // Parameterized Construcor
        public Queue(int size)
        {
            _head =0;
            _tail =0;
            _count =0;
            _capacity =4;
            Array =new Type[size];
        }
       // Method for Enqueue
        public void Enqueue(Type data)
        {
            if(_tail == _capacity)
            {
                GrowSize();
            }
            Array[_tail] = data;
            _tail++;
           _count++;
        }

        public void GrowSize()
        {
            _capacity = _capacity*2;
          Type[] NewArray = new Type[_capacity];

          for(int i=0;i<_tail;i++)
          {
            NewArray[i] = Array[i];
          }
          Array = NewArray; 
        }


        // DEQUEUE METHOD
        public Type Dequeue()
        {
            Type value = default(Type);
            if(_head > _tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else 
            {
                 value=Array[_head];
                 _head++;
                 _count --;
            } return value;
        }

        //peak 
        public Type Peek()
        {
            Type value = default(Type);
            if(_head > _tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else 
            {
                 value=Array[_head];
            } return value;
        }
        // Contains
        public bool Contains(Type data)
        {
            bool value = false;
            for(int i=0;i<_tail;i++)
            {
                if(Array[i].Equals(data))
                {
                    value = true;
                }
            } return value;
        }
// Pending

    }


     

    
}