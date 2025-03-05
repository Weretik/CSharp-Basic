using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Generic_Constraints
{
    /*
             * Завдання 2

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість використання екземпляра для створення парку машин. 
            Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року її випуску, 
            індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.
            Створіть спосіб видалення всіх машин автопарку.
            */
    class CarCollection <T> where T: Car
    {
        T[] cars;
        public int LenthCarColection 
        {
            get 
            {
                if (cars == null)
                {
                    return 0;
                }
                return cars.Length; 
            }
        }
        
        public T this[int index]
        {
            get
            {
                return cars[index];
            }
        }
        public void AddCar(T car)
        {
            if (cars == null)
            {
                cars = new T[] { car };  
            }
            else
            {
                T[] temp = new T[cars.Length + 1];
                for (int i = 0; i < cars.Length; i++)
                {
                    temp[i] = cars[i];
                }
                temp[^1] = car;
                cars = temp;
            }
        }
        public void ClearAllCar()
        {
            cars = null;
        }
    }
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
