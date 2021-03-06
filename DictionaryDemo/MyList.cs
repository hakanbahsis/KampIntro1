using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
   public class MyList<T,U>
    {
        T[] keys;
        U[] values;
        public MyList()
        {
            keys = new T[0];
            values = new U[0];
        }
        public void Add(T key,U value)
        {
            T[] tempKeys = keys;
            keys = new T[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            U[] tempValue = values;
            values = new U[values.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];                    
            }
            values[values.Length - 1] = value;

        }
        public int Length
        {
            get { return keys.Length; }
        }

        public U[] Value
        {
            get { return values; }
        }
    }
}
