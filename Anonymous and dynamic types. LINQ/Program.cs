using System.Text;

namespace Anonymous_and_dynamic_types._LINQ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            Уявіть, що ви пишете програму для Автостанції і вам необхідно створити просту колекцію автомобілів з такими даними:
            марка автомобіля, 
            модель, 
            рік випуску, 
            колір.
            
            А також другу колекцію з моделлю автомобіля, ім'ям покупця та його номером телефону. 
            Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця одного з автомобілів і повну характеристику придбаної ним моделі. 
            */

            var cars = new[]
            {
                new {Brand = "BMW", Model = "X5", Year = 2015, Color = "Black"},
                new {Brand = "Audi", Model = "A6", Year = 2016, Color = "White"},
                new {Brand = "Mercedes", Model = "S500", Year = 2017, Color = "Silver"},
                new {Brand = "Toyota", Model = "Camry", Year = 2018, Color = "Red"},
                new {Brand = "Nissan", Model = "GTR", Year = 2019, Color = "Blue"}
            };

            var customers = new[]
            {
                new {Model = "X5", Name = "Ivan", Phone = "0990672781"},
                new {Model = "A6", Name = "Petro", Phone = "0990672782"},
                new {Model = "S500", Name = "Oleg", Phone = "0990672783"},
                new {Model = "Camry", Name = "Vasyl", Phone = "0990672784"},
                new {Model = "GTR", Name = "Ostap", Phone = "0990672785"}
            };

            var query = from car in cars
                        join sustomer in customers
                        on car.Model equals sustomer.Model
                        where sustomer.Name == "Ivan"
                        select new
                        {
                            Name = sustomer.Name,
                            Phone = sustomer.Phone,
                            Brand = car.Brand,
                            Model = car.Model,
                            Year = car.Year,
                            Color = car.Color
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.Name}\nPhone: {item.Phone}\nBrand: {item.Brand}\nModel: {item.Model}\nYear: {item.Year}\nColor: {item.Color}\n");
            }

            /*
             * Завдання 3 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Використовуючи динамічні та анонімні типи даних, створіть Англо-Російський словник на 10 слів та виведіть на екран його зміст. 
            */
            Console.WriteLine();
            List<dynamic> dictionary = new List<dynamic>
            {
                new { English = "Hello", Ukrainian = "Привіт" },
                new { English = "Goodbye", Ukrainian = "До побачення" },
                new { English = "Thank you", Ukrainian = "Дякую" },
                new { English = "Please", Ukrainian = "Будь ласка" },
                new { English = "Yes", Ukrainian = "Так" },
                new { English = "No", Ukrainian = "Ні" },
                new { English = "Cat", Ukrainian = "Кіт" },
                new { English = "Dog", Ukrainian = "Собака" },
                new { English = "House", Ukrainian = "Дім" },
                new { English = "Book", Ukrainian = "Книга" }
            };

            Console.WriteLine("Англо-Український словник:");
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.English} - {entry.Ukrainian}");
            }

            /*
             * Завдання 5 

             Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть клас Calculator, методи якого приймають аргументи та повертають значення типу dynamic.
            */
            Console.WriteLine();
            Calculator calc = new Calculator();

            dynamic result1 = calc.Add(5, 10);
            dynamic result2 = calc.Subtract(10.5, 4.2);
            dynamic result3 = calc.Multiply(2, 3);
            dynamic result4 = calc.Divide(10, 2);
            dynamic result5 = calc.Divide(10, 0);

            Console.WriteLine($"Додавання: 5 + 10 = {result1}");
            Console.WriteLine($"Віднімання: 10.5 - 4.2 = {result2}");
            Console.WriteLine($"Множення: 2 * 3 = {result3}");
            Console.WriteLine($"Ділення: 10 / 2 = {result4}");
            Console.WriteLine($"Ділення на нуль  : {result5}");

        }
    }

    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                return "Помилка: Ділення на нуль";
            }
            return a / b;
        }
    }
}