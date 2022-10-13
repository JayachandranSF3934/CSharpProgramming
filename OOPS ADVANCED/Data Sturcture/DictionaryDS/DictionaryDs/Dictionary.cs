using System;
namespace DictionaryDs
{
    public partial class Dictionary<TKey, TValue>
    {
        //Feild
        private int _capacity;   // Field for Capacity
        private int _count;  // Field for Count

       // Property 
        public int Size { get{return _capacity;} }  
        public int Count { get{return _count;} }  // get from Field 
        public KeyValue<TKey,TValue> []Array { get; set; }

        // Constructor
        public Dictionary()
        {
            _count =0;
            _capacity=4;
            Array  =new KeyValue<TKey,TValue>[_capacity];
        }
        // parameterized Constructor
        public Dictionary(int Size)
        {
            _count =0;
            _capacity =Size;
            Array = new KeyValue<TKey,TValue>[_capacity];
        }

        // Add Method
        public void Add(TKey key , TValue value)
        {
            if (_capacity == _count)
            {
                GrowSize();   // Expanding Dictionary Size
            }

            bool temp = LinearSearch(key,out int index);  // Using Linear Search   // By using out index we don't use this
            if(temp == true)
            {
                System.Console.WriteLine("Invalid / Duplicate Key");
            }
            if(temp == false)
            {
                KeyValue<TKey,TValue> entry = new KeyValue<TKey, TValue>();
                entry.Key = key;
                entry.Value = value;
                Array[_count]= entry;
                _count++;
            }  
        }
        //Growsize Method  or EXpand
        public void GrowSize()
        {
            _capacity = _capacity*2;
            KeyValue<TKey,TValue> [] newArray  =new KeyValue<TKey,TValue>[_capacity];

            for(int i=0;i<Count;i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray;
        }

        // Linear Search   normal Use

        /* public bool LinearSearch(TKey key)   // Using Linear Search TKey key
        {
            bool values =false;
            for(int i=0;i<Array.Length;i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    values = true;
                    break;
                }
            }
            return values;
        } */

        // We have Two Requirment so we want change it
        public bool LinearSearch(TKey key,out int index)   // Using Linear Search TKey key
        {
            bool values =false;
            index = 0;
            for(int i=0;i<Array.Length;i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    index = i;
                    values = true;
                    break;
                }
            }
            return values;
        }

        public TValue this [TKey key]
        {
            get{
                TValue output = default(TValue);
                int index =0;
                bool temp = LinearSearch(key,out index);
                if(temp)
                {
                 output = Array[index].Value;
                }
                else{
                    System.Console.WriteLine("Invalid Key");
                }return output;   
            }
            set{
                int position =0;
                bool temp = LinearSearch(key, out position);
                if(temp)
                {
                    Array[position].Value = value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Key");
                }
            }
        }
    }   
}