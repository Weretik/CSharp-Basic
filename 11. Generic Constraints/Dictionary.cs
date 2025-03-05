using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Generic_Constraints
{
    public class Dictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public Dictionary()
        {
            keys = new TKey[10]; 
            values = new TValue[10];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (count < keys.Length)
            {
                keys[count] = key;
                values[count] = value;
                count++;
            }
            else
            {
                Console.WriteLine("Немає місця для додавання нових елементів");
            }
        }
        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (EqualityComparer<TKey>.Default.Equals(keys[i], key))
                    {
                        return values[i];
                    }
                }
                return default;
            }
        }
        public int Count => count;
    }
}
