using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public TKey[] Keys
        {
            get { return keys; }

        }

        public TValue[] Values
        {
            get { return values; }
        }

        public void Add(TKey key, TValue value)
        {
            var tempKeys = keys;
            var tempValues = values;

            keys = new TKey[tempKeys.Length + 1];
            values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
