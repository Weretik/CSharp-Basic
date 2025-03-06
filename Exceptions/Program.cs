namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            /*
             * Завдання 2

                Потрібно описати структуру з ім'ям Worker, що містить такі поля:
                • прізвище та ініціали працівника;
                • назва займаної посади;
                • рік надходження працювати.

                Написати програму, яка виконує такі дії:
                • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
                • якщо значення року введено не у відповідному форматі видає виняток;
                • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.
            */

            Worker[] workers = new Worker[2];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Працівник {i+1}");

                Console.WriteLine("Введіть імя співробітника");
                string firstName = Console.ReadLine();

                Console.WriteLine("Введіть Фамілію співробітника");
                string lastName = Console.ReadLine();

                Console.WriteLine("Введіть Посаду співробітника");
                string position = Console.ReadLine();

                Console.WriteLine("Введіть рік народження співробітника");

                int years;
                try
                {
                    years = int.Parse(Console.ReadLine());
                    if (years < 1900 || years > DateTime.Now.Year)
                    {
                        throw new Exception($"Невірний формат дати, введіть рік (від 1990 до {DateTime.Now.Year})");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    years= int.Parse(Console.ReadLine());
                }

                workers[i] = new Worker(firstName, lastName, position, years);
            }
            Array.Sort(workers, (x, y) => x.FirstName.CompareTo(y.FirstName));
            Console.WriteLine();
            Console.WriteLine("Інфорамація про співробітників:");

            foreach (Worker worker in workers)
            {
                Console.Write($"Імя: {worker.FirstName}, Стаж: {worker.GetExperience()} років");
                Console.WriteLine();
            }
        }
    }
}
