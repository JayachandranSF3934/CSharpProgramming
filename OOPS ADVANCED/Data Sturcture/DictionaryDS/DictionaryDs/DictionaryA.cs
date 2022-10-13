using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
    public partial class Dictionary<TKey,TValue>
    {
        // Contains Key Method
        public bool ContainsKey(TKey key)
        {
            int index=0;
            bool temp = LinearSearch(key,out index);
            return temp;
        }
        // Contains Value Method
        public bool ContainsValue(TValue values)
        {
            bool temp =false;
            for(int i=0;i<Array.Length;i++)
            {
                if(values.Equals(Array[i].Value))
                {
                    temp = true;
                    break;
                }
            }
            return temp;   
        }
        // Element At
        public KeyValue<TKey,TValue> ElementAt(int index)
        {
            KeyValue<TKey,TValue> output = null;
            index = 0;
            for(int i=0;i<Array.Length;i++)
            {
             if(index.Equals(Array[i]))
             {
                output = Array[i];
                break;
             }   
            }
            return output;
        }
        // Remove Method
        public bool Remove(TKey key)
        {
            int index=0;
            bool condition=false;
            KeyValue<TKey,TValue> [] ArrayUpdate= new KeyValue<TKey, TValue>[_capacity];
            for(int i=0;i<Count;i++)
            {
                if(Array[i].Key.Equals(key))
                {
                    index=i;
                }
            }
            for(int i=0; i<Count; i++)
            {
                if(i<=index)
                {
                    ArrayUpdate[i]=Array[i+1];
                }
            }
            return condition;
          }
        
    }
}