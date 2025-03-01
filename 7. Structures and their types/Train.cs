using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Structures_and_their_types
{
    /*
             * Завдання 2 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Потрібно: 
            Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення.
            Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу Train
            (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, номер якого введено з клавіатури
            (якщо таких поїздів немає, вивести відповідне повідомлення). 
            */
    struct Train
    {
        public string destination;
        public int trainNumber;
        public string departureTime;
        public Train(string destination, int trainNumber, string departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }
        public void Show()
        {
            Console.WriteLine($"Destination: {destination}, Train number: {trainNumber}, Departure time: {departureTime}");
        }
    }
}
