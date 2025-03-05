namespace _11._Generic_Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
