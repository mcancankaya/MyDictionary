using System;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    Console.WriteLine("Aynı Key Mevcut. Farklı key giriniz. Key : " + key);
                    return;
                }
            }

            Key[] tempKeys;
            Value[] tempValues;

            tempKeys = keys;
            tempValues = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < keys.Length - 1; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public Value[] GetValues()
        {
            return values;
        }


        public Value GetByValue(Key key)
        {
            int result = -1;
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    result = i;
                }

            }
            return values[result];
        }

    }
}
