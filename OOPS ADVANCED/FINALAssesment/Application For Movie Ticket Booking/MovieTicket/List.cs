
namespace MovieTicket
{
    public partial class List<Type>
    { 
      //Fields
        private int _capacity;   
        private int _count; 
        private Type[] Array { get; set; }

        public int Capacity { get{return _capacity;} } 
        public int Count { get{return _count;} } 
      // For Loop inDexer
        public Type this[int i] { get{return Array[i];} set{ Array[i]= value;} } 

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

       // Method for Add 
       public void Add(Type data)
       {
         if(_count == _capacity)
         {
            GrowSize();
         }
          Array[_count] = data;   
          _count++;
       }
         // Method for GrowSize
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