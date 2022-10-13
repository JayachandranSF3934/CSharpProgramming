using System;

namespace CollegeAdmission
{
    public partial class List<Type>
    { 
        private int _capacity;   // Field for Capacity
        private int _count;  // Field for Count
        private Type[] Array { get; set; }

        public int Capacity { get{return _capacity;} }  // To NOt Load From Outide Remove Set in Propertty   // Get Fom felid
        public int Count { get{return _count;} }  // get from Field 

        public Type this[int i] { get{return Array[i];} set{ Array[i]= value;} }   // Indexer

     // default Constructor
       public List()
       {
          _count =0;
          _capacity =4;
          Array = new Type[_capacity];
       }

       // Parameterized Constructor
       public List(int size)
       {
        _count=0;
        _capacity = size;
        Array = new Type[_capacity];
       }

       // Method for Add Element
       public void Add(Type data)   // Type of Datas  // Add Element to the list
       {
         if(_count == _capacity)
         {
            GrowSize();
         }
          Array[_count] = data;   //  
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
    }
}