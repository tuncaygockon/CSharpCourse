using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHW
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            T1[] _keys = keys;
            T2[] _values = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < _keys.Length; i++)
            {
                keys[i] = _keys[i];
                values[i] = _values[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public T1[] Keys
        {
            get { return keys; }
        }

        public T2[] Values
        {
            get { return values; }
        }
    }
}
