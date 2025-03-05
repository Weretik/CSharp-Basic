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

            /*
             * Завдання 3 

            Створіть проект Console Application, де реалізуйте типізований клас "Чарівний мішок".
            Чарівність полягає в тому, що подарунок сам з'являється у мішку та залежить від того, хто намагається відкрити мішок. 
            Причому подарунок для однієї істоти може з'явитись лише 1 раз на день. 
            Використовуйте обмеження типу - інтерфейс із властивістю, що зберігає тип істоти, яка намагається отримати подарунок із мішка.
            */
            Console.WriteLine();
            Human human = new Human("Людина");
            Elf elf = new Elf("Ельф");

            MagicBag<ICreature> magicBag = new MagicBag<ICreature>();

            Console.WriteLine(magicBag.GiveGift(human));
            Console.WriteLine(magicBag.GiveGift(elf));    
            Console.WriteLine(magicBag.GiveGift(human));
            /*
             * 
            Завдання 4 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть метод, що розширює: public static T[ ] GetArray(this MyList list) Застосуйте розширюючий метод до екземпляра типу MyList, 
            розробленого в домашньому завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.
            */
            Console.WriteLine();
            int[] arrayInt = list.GetArrayList();
            foreach (var item in arrayInt)
            {
                Console.WriteLine(item);
            }

        }
    }
}
