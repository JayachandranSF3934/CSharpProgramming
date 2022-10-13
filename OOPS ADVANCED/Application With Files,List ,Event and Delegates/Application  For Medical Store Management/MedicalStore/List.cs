using System;

namespace MedicalStore
{
    public partial class List<Type>
    { 
        private int _capacity;  
        private int _count; 
        private Type[] Array { get; set; }

        public int Capacity { get{return _capacity;} } 
        public int Count { get{return _count;} } 

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
       public void Add(Type data)   
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

       public void AddRange(List <Type> datas )
       {
         Type[] ArrayNew = new Type[_count+datas._count];
         for(int i=0;i<_count;i++)
         {
            ArrayNew[i] = Array[i];
         }
         for(int i=0;i<datas._count;i++)
         {
            ArrayNew[_count+i] = datas[i];
         }
         Array = ArrayNew;
         _count = _count+datas._count;
       }
    }
}