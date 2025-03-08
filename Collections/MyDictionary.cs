using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public MyDictionary()
        {
            keys = new TKey[10];
            values = new TValue[10];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(TKey key, TValue value)
        {
            if (count == keys.Length)
            {
                Array.Resize(ref keys, keys.Length * 2);
                Array.Resize(ref values, values.Length * 2);
            }

            keys[count] = key;
            values[count] = value;
            count++;
        }

        public TValue this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new Exception("Індекс поза межами колекції.");
                return values[index];
            }
        }

        public void Iterate()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Ключ: {keys[i]}, Значення: {values[i]}");
            }
        }
    }
}
