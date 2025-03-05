using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Generic
{
    
public class MyList<T>
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
    /*
     * 
    Завдання 4 

    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть метод, що розширює: public static T[ ] GetArray(this MyList list) Застосуйте розширюючий метод до екземпляра типу MyList, 
    розробленого в домашньому завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.
    */
    public static class MyListExtensions
    {
        public static T[] GetArrayList<T>(this MyList<T> list)
        {
            if (list.Count == 0)
            {
                return  new T[0];
            }
            else
            {
                T[] arrayList = new T[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    arrayList[i] = list[i];
                }
                return arrayList;
            }
        }
    }
}
