namespace _11._Generic_Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            /*
             * Завдання 2

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість використання екземпляра для створення парку машин. 
            Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року її випуску, 
            індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.
            Створіть спосіб видалення всіх машин автопарку.
            */
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.AddCar(new Car("BMW", 2000));
            carCollection.AddCar(new Car("Audi", 2005));
            carCollection.AddCar(new Car("Mercedes", 2010));
            carCollection.AddCar(new Car("Toyota", 2015));
            carCollection.AddCar(new Car("Nissan", 2020));

            Console.WriteLine($"В автопарку {carCollection.LenthCarColection} машин");
            carCollection.ClearAllCar();
            Console.WriteLine($"В автопарку {carCollection.LenthCarColection} машин");


            /*
             * 
             * Завдання 3

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть клас Dictionary. Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу 
            Dictionary із простору імен System.Collections.Generic. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання пар елементів, 
            індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості пар елементів.
            */
            Console.WriteLine();
            var dictionary = new Dictionary<string, int>();

            dictionary.Add("apple", 10);
            dictionary.Add("banana", 20);

            Console.WriteLine($"Кількість яблук: {dictionary["apple"]}");
            Console.WriteLine($"Кількість бананів: {dictionary["banana"]}");

            Console.WriteLine($"Кількість пар елементів: {dictionary.Count}");
        }



    }
    
}
