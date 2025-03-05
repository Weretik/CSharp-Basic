using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Generic
{
    
    class MyList<T>
    {
        private T[] array;
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public void AddToList(T value)
        {
            if (array == null)
            {
                array = new T[] { value };
            }
            else
            {
                T[] newArray = new T[array.Length + 1];
                array.CopyTo(newArray, 0);
                newArray[array.Length] = value;
                array = newArray;
            }
        }

        public int Count
        {
            get
            {
                return array == null ? 0 : array.Length;
            }
        }
    }
}
