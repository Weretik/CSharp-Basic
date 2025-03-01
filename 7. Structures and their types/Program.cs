namespace _7._Structures_and_their_types
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
            Потрібно: 
            Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення.
            Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу Train
            (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, номер якого введено з клавіатури
            (якщо таких поїздів немає, вивести відповідне повідомлення). 
            */

            //Створюємо масив з 8 потягів
            Train[] trains = new Train[8];

            //Заповнюємо масив потягами
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введіть інформацію про потяг {i + 1}");

                Console.Write("Назва пункту призначення: ");
                string destination = Console.ReadLine();

                Console.Write("Номер поїзда: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Час відправлення: ");
                string departureTime = Console.ReadLine();
                trains[i] = new Train(destination, trainNumber, departureTime);
                Console.WriteLine();
            }
            //Сортуємо масив за номерами поїздів
            for (int i = 0; i < trains.Length - 1; i++)
            {
                for (int j = 0; j < trains.Length - i - 1; j++)
                {
                    if (trains[j].trainNumber > trains[j + 1].trainNumber)
                    {

                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            }
            //Виводимо інформацію про потяг, номер якого введено з клавіатури
            Console.WriteLine();
            Console.WriteLine("Введіть номер потягу який вас цікавить: ");
            int numberTrain = int.Parse(Console.ReadLine());
            foreach (var train in trains)
            {
                if (train.trainNumber == numberTrain)
                {
                    train.Show();
                    return;
                }
            }


            /*
             * 
             * Завдання 3 

            Створіть клас MyClass і структуру MyStruct, які містять поля public string change. 
            У класі Program створіть два методи: static void ClassTaker(MyClass myClass), який надає полю change екземпляра myClass значення «змінено». 
            static void StruktTaker(MyStruct myStruct), який надає полю change екземпляра myStruct значення «змінено». 
            Продемонструйте різницю у використанні класів та структур, створивши у методі Main() екземпляри структури та класу. 
            Змініть значення полів екземплярів на «не змінено», а потім викличте методи ClassTaker і StruktTaker. 
            Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. 
            */

            MyClass classInstance = new MyClass();
            classInstance.change = "не змінено";

            MyStruct structInstance = new MyStruct();
            structInstance.change = "не змінено";

            ClassTaker(classInstance);
            StruktTaker(structInstance);

            // Виведення результатів
            Console.WriteLine("Значення поля change у екземплярі класу: " + classInstance.change);
            Console.WriteLine("Значення поля change у екземплярі структури: " + structInstance.change);

            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "змінено";
            }

            static void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "змінено";
            }

            /*
             * Висновок:
            Клас передається за посиланням, і всі зміни в методі впливають на оригінальний об'єкт.
            Структура передається за значенням, тому зміни відбуваються тільки в локальній копії, а оригінальний екземпляр залишається незмінним.
            */


            /*Завдання 5

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість. 
            У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.
            */

            Notebook myNotebook = new Notebook("ThinkPad X1 Carbon", "Lenovo", 45000);
            myNotebook.DisplayInfo();
        }

        //Завдання 3 
        class MyClass
        {
            public string change;
        }
        struct MyStruct
        {
            public string change;
        }

        // Завдання 5
        struct Notebook
        {
            public string model;
            public string manufacturer;
            public double price;
            public Notebook(string model, string manufacturer, double price)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Model: {model}, Manufacturer: {manufacturer}, Price: {price}");
            }

        }
    }
}
