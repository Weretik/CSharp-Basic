using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class MyList <T>: IEnumerable<T>
    {
        T[] array;

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public void Add(T item)
        {
            if (array == null)
            {
                array = new T[1];
                array[0] = item;
            }
            else
            {
                T[] tempArray = new T[array.Length + 1];
                array.CopyTo(tempArray, 0);
                tempArray[^1] = item;
                array = tempArray;
            }
        }

        public int Lenth
        {
            get
            {
                return array.Length;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
