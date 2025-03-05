namespace _10._Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            /*
             * Завдання 2 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас MyList. 
            Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу List. 
            Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для 
            отримання значення елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів.
            */

            MyList<int> list = new MyList<int>();
            list.AddToList(25);
            list.AddToList(35);
            list.AddToList(45);
            list.AddToList(55);

            Console.WriteLine($"Другий елемент в списку: {list[1]}");
            Console.WriteLine($"Загальна кількість елементыв в списку: {list.Count}");
        }
    }
}
