using System;

namespace StackManipulation
{
    public partial class Stack<Type>
    {
        // Felid
        private Type [] Array { get; set; }
        private int _count;
        private int _capacity;

        // Property
        public int Count { get{return _count;} }
       

       // Construcor
       public Stack()
       {
        _count =0;
        _capacity =4;
        Array  = new Type[_capacity];  // array datatype should be type for type list
       }
       
       // Parametrized Contructor

       public Stack(int size)
       {
        _count =0;
        _capacity =size;
        Array = new Type[_capacity];
       }

       // Method  push

       public void Push(Type data)
       {
        if(_count == _capacity)
        {
            GrowSize();
        }
        Array[_count] = data;
        _count++;
       }
       public void GrowSize()
       {
        _capacity = _capacity*2;
        Type[] NewArray = new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            NewArray[i] = Array[i];
        } 
        Array = NewArray;
       }

       // Pop Method

       public Type Pop()
       {
        Type value = default(Type);
        if(_count !=-1)
        {
            System.Console.WriteLine("{0} Popped from stack ",Array[_count]);
            value =Array[_count];
            _count--;
            
        } else if(_count<=0)
        {
            System.Console.WriteLine("Empty Stack");
        }
        return value;
       }

       // contains method
       public bool Contains(Type data)
       {
            bool value =false;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(data))
                {
                    value = true;
                } 
            } return value;  
       }


       // Peek Method
       public Type Peek()
       {
        Type value = default(Type);
        if(_count == )

       }

       /* IF TOP = NULL
            PRINT STACK IS EMPTY
            Go to Step 3
Step 2: RETURN STACK[TOP]
Step 3: END   

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
            } return value;  */

       

       // Clean Method

       


    }
}