namespace _7._Structures_and_their_types
{
    internal class Program
    {
        static void Main(string[] args)
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

        }
    }
}
