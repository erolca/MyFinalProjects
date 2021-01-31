using System;
using System.Collections.Generic;
using System.Text;

namespace Dict
{
    class UserDict<T, TT>
    {
        T[] _keys;      
        TT[] _values;   

        public UserDict()
        {
            _keys = new T[0];   
            _values = new TT[0]; 
        }

        public void Add(T _key, TT _value)
        {
            T[] keyArray = _keys;
            TT[] valueArray = _values;
            _keys = new T[_keys.Length + 1];
            _values = new TT[_values.Length + 1];

            for (int i = 0; i < keyArray.Length; i++)
            {
                _keys[i] = keyArray[i];
            }
            for (int i = 0; i < valueArray.Length; i++)
            {
                _values[i] = valueArray[i];
            }
            _keys[_keys.Length - 1] = _key;
            _values[_values.Length - 1] = _value;
        }
        public void ShowKeysValues()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                T key = _keys[i];
                TT value = _values[i];
                Console.WriteLine(key + "-" + value);
            }
        }
    }
}
