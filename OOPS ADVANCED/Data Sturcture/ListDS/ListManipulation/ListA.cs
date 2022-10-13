using System;
namespace ListManipulation
{
    public partial class List<Type>
    {
        public void Insert(int index, Type data)
        {
            Type[] ArrayOne = new Type[_capacity +1];
            for(int i=0;i<_count+1;i++)
            {
                if (i < index )
                {
                    ArrayOne[i] = Array[i];
                }else if (i >= index)
                {
                    ArrayOne[i] = Array[i+1];
                }
            } Array = ArrayOne; 
            _count++;
        }

        public void RemoveAt(int index)
        {
            for(int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i] = Array[i+1];
                }  
            } 
            _count --;
        }

        public void Remove( Type data)
        {
            int count=0;
            for(int i=0;i<Array.Length-1;i++)
            {
                if(data.Equals(Array[i]))
                {
                    count =i;
                }
            }
            for(int i=0;i<Array.Length-1;i++)
            {
                if(i>count)
                {
                    Array[i] = Array[i+1];

                }
                _count--;
            }
        }
    }

}