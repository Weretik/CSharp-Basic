using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(int x, int y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Координати: ({X}, {Y})");
            Console.WriteLine($"Ціна: {Price}$");
            Console.WriteLine($"Швидкість: {Speed} км/год");
            Console.WriteLine($"Рік випуску: {Year}");
        }
    }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }

        public Plane(int x, int y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nЛітак:");
            base.ShowInfo();
            Console.WriteLine($"Висота польоту: {Height} м");
            Console.WriteLine($"Кількість пасажирів: {Passengers}");
        }
    }

    class Car : Vehicle
    {
        public Car(int x, int y, double price, double speed, int year)
            : base(x, y, price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nАвтомобіль:");
            base.ShowInfo();
        }
    }

    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(int x, int y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nКорабель:");
            base.ShowInfo();
            Console.WriteLine($"Кількість пасажирів: {Passengers}");
            Console.WriteLine($"Порт приписки: {Port}");
        }
    }
}
